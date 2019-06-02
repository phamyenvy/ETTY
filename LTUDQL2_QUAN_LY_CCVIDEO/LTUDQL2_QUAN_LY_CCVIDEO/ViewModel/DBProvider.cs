﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Model
{
    public class DBProvider
    {
        public static List<VideoInfo> getTrendingVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = (from v in qlccv.Videos
                                  orderby v.LuotXem descending
                                  select v).Take(10).ToList();

                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in vd)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }
        public static List<VideoInfo> getSearchVideo(string[] searchTerm)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd =  qlccv.Videos.SqlQuery("select * from Video WHERE CONTAINS(TenVideo, {0}) OR CONTAINS(MoTa, {1})", searchTerm[0], searchTerm[0]).ToList();

                for (int i = 1; i < searchTerm.Length; i++)
                {
                    List<Video> temp = qlccv.Videos.SqlQuery("select * from Video WHERE CONTAINS(TenVideo, {0}) OR CONTAINS(MoTa, {1})", searchTerm[i], searchTerm[i]).ToList();
                    vd.AddRange(temp);
                    
                }


                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in vd)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }
        public static VideoInfo getVideo(int ID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Video vd = qlccv.Videos.Where(v => v.MaVideo == ID).SingleOrDefault();
                VideoInfo info = new VideoInfo();
                    info.ID = vd.MaVideo.ToString();
                    info.Title = vd.TenVideo;
                    info.Path = vd.LinkImage;
                    info.PathVideo = vd.LinkTrailer;
                    info.Description = vd.MoTa;
                    info.Views = vd.LuotXem.ToString();


                return info;
            }
        }
        public static int getIDAcc(string mail)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan tk = qlccv.TaiKhoans.Where(v => v.TenTaiKhoan == mail).SingleOrDefault();
                
                return tk.MaTaiKhoan;
            }
        }
        public static int checkExitsCard(string IDCard)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                The the = qlccv.Thes.Where(v => v.IDCard == IDCard).SingleOrDefault();
                if(the != null)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
                
            }
        }

        public static void checkProfileMain(int ProfileID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Profile pf = qlccv.Profiles.Where(v => v.MaProfile == ProfileID).SingleOrDefault();
                pf.AvatarLink = "1";
                qlccv.SaveChanges();

                
            }
        }
        public static void uncheckProfileMain(int ProfileID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Profile pf = qlccv.Profiles.Where(v => v.MaProfile == ProfileID).SingleOrDefault();
                pf.AvatarLink = "2";
                qlccv.SaveChanges();


            }
        }
        public static void paySuccess(string mail, CapDoTaiKhoan capDo)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {

                TaiKhoan tk = qlccv.TaiKhoans.Where(v => v.TenTaiKhoan == mail).SingleOrDefault();
                tk.NgayHetHan = tk.NgayHetHan.Value.AddDays(30);
                tk.LoaiTaiKhoan = 1;
                tk.CapDo = capDo.MaCapDo;
                qlccv.SaveChanges();


            }
        }

        public static List<Profile> getPf(int IDAcc)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Profile> pf = qlccv.Profiles.Where(v => v.TaiKhoan == IDAcc).ToList();

                return pf;
            }
        }
        public static void updateProfile(int IDProfile, string newName)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Profile p = qlccv.Profiles.Where(v => v.MaProfile == IDProfile).SingleOrDefault();
                p.TenHienThi = newName;
                qlccv.SaveChanges();
            }
        }
        public static int checkCodeCard(string IDCard, string code)
        {
            try
            {
                using (var qlccv = new QuanLyCCVEntities())
                {
                    The p = qlccv.Thes.Where(t =>t.IDCard == IDCard).SingleOrDefault();
                    if(p.Code == code)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            catch
            {
                return 0;
            }

        }
        public static void addNewCard(string IDCard, string fName, string lName, string code, int maTK)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                The the = qlccv.Thes.Where(t => t.IDCard == IDCard).SingleOrDefault();
                if (the != null)
                {
                    if (the.FirstName == fName && the.LastName == lName && the.Code == code)
                    {
                        IDCard = the.IDCard;
                    }
                    else
                    {
                        MessageBox.Show("Add Fail!");
                        return;
                    }
                }
                else
                {

                    The TheNew = new The() { IDCard = IDCard, FirstName = fName, LastName = lName, Code = code };
                    qlccv.Thes.Add(TheNew);
                    TaiKhoan p = qlccv.TaiKhoans.Where(v => v.MaTaiKhoan == maTK).SingleOrDefault();
                    p.IDThe = IDCard;
                    qlccv.SaveChanges();

                    MessageBox.Show("Add Successful!");


                }
            }
        }
        public static string getLevelAcc(TaiKhoan tk)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                CapDoTaiKhoan level = qlccv.CapDoTaiKhoans.Where(l => l.MaCapDo == tk.CapDo).SingleOrDefault();

                return level.TenCapDo;
            }
        }
        public static TaiKhoan reloadTK(TaiKhoan tk)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan th = qlccv.TaiKhoans.Where(t => t.MaTaiKhoan == tk.MaTaiKhoan).SingleOrDefault();

                return th;
            }
        }




        public static List<Video> getMainVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = qlccv.Videos.OrderByDescending(x => x.LuotXem).Take(1).ToList();
                return vd;
            }
        }
        public static List<CapDoTaiKhoan> getCapDo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<CapDoTaiKhoan> cd = qlccv.CapDoTaiKhoans.ToList();
                return cd;
            }
        }
        public static List<String> getLoaiVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<String> loai = (from v in qlccv.LoaiVideos
                                  select v.TenLoaiVideo).ToList();
                return loai;
            }
        }
        public static List<VideoInfo> getMainVideo_Phu()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = qlccv.Videos.OrderByDescending(x => x.LuotXem).Take(1).ToList();
                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in vd)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);

                }
                return vdinfo;

            }
        }
        public static List<VideoInfo> getNewVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = (from v in qlccv.Videos
                                  orderby v.NgaySanXuat descending
                                  select v).Take(10).ToList();

                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in vd)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }
        public static List<VideoInfo> getListVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = (from v in qlccv.Videos
                                  select v).ToList();

                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in vd)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }


        public static List<VideoInfo> getMyVideo(Profile pf)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                if((from v in qlccv.YeuThich_XemGanDay
                                                  join vd in qlccv.Videos on v.MaVideo equals vd.MaVideo
                                                  where v.MaProfile == pf.MaProfile && v.LoaiLuuTru == 1
                                                  orderby v.ThoiGian descending
                                                    select vd).ToList()==null)
                {
                    return null;
                }

                List<Video> video = (from v in qlccv.YeuThich_XemGanDay
                                                  join vd in qlccv.Videos on v.MaVideo equals vd.MaVideo
                                                  where v.MaProfile == pf.MaProfile && v.LoaiLuuTru == 1
                                     orderby v.ThoiGian descending
                                     select vd).ToList();

                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in video)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }
        public static List<VideoInfo> getRecently(Profile pf)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                if ((from v in qlccv.YeuThich_XemGanDay
                     join vd in qlccv.Videos on v.MaVideo equals vd.MaVideo
                     where v.MaProfile == pf.MaProfile && v.LoaiLuuTru == 3
                     orderby v.ThoiGian descending
                     select vd).ToList() == null)
                {
                    return null;
                }

                List<Video> video = (from v in qlccv.YeuThich_XemGanDay
                                     join vd in qlccv.Videos on v.MaVideo equals vd.MaVideo
                                     orderby v.ThoiGian descending
                                     where v.MaProfile == pf.MaProfile && v.LoaiLuuTru == 3
                                     select vd).ToList();

                List<VideoInfo> vdinfo = new List<VideoInfo>();

                foreach (Video v in video)
                {
                    VideoInfo info = new VideoInfo();
                    info.ID = v.MaVideo.ToString();
                    info.Title = v.TenVideo;
                    info.Path = v.LinkImage;
                    info.PathVideo = v.LinkTrailer;
                    info.Description = v.MoTa;
                    info.Views = v.LuotXem.ToString();
                    vdinfo.Add(info);
                }

                return vdinfo;
            }
        }


        public static Video getVideoByID(int ID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Video vd = qlccv.Videos.Where(v => v.MaVideo == ID).SingleOrDefault();

                return vd;
            }
        }


        public static bool comparePermissionVideo(TaiKhoan tk, Video vd)
        {
            if(tk.CapDo>=vd.CapDoVideo)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string getNameLevel(Video vd)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                CapDoTaiKhoan cdtk = qlccv.CapDoTaiKhoans.Where(v => v.MaCapDo == vd.CapDoVideo).SingleOrDefault();

                return cdtk.TenCapDo;
            }
        }

        public static void setAutoLevelAccount(TaiKhoan tk)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan t = qlccv.TaiKhoans.Where(o => o.MaTaiKhoan == tk.MaTaiKhoan).SingleOrDefault();
                
                if(t.LoaiTaiKhoan!=0)
                {
                    if (t.NgayHetHan <= DateTime.Now)
                    {
                        t.LoaiTaiKhoan = 0;
                        qlccv.SaveChanges();
                    }
                }
             
            }
        }
       
        public static bool isPaid(TaiKhoan tk)
        {
            setAutoLevelAccount(tk);
            using (var qlccv = new QuanLyCCVEntities())
            {
                TaiKhoan t = qlccv.TaiKhoans.Where(o => o.MaTaiKhoan == tk.MaTaiKhoan).SingleOrDefault();

                if(t.LoaiTaiKhoan==1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }
        public static List<Profile> getProfile(TaiKhoan tk)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Profile> pro = qlccv.Profiles.Where(o => o.TaiKhoan == tk.MaTaiKhoan).ToList();

                return pro;
            }
        }

        public static bool setYeuThichVideo(int MaProfile, int IDVideo,int LoaiLuuTru)
        {
            YeuThich_XemGanDay yt = new YeuThich_XemGanDay();
            yt.MaProfile = MaProfile;
            yt.MaVideo = IDVideo;
            yt.LoaiLuuTru = LoaiLuuTru;
            yt.ThoiGian = DateTime.Now;
            using (var qlccv = new QuanLyCCVEntities())
            {
                YeuThich_XemGanDay ytcheck = qlccv.YeuThich_XemGanDay.Where(a => a.MaProfile == MaProfile && a.MaVideo == IDVideo && a.LoaiLuuTru == LoaiLuuTru).SingleOrDefault();
                if(ytcheck==null)
                {
                    qlccv.YeuThich_XemGanDay.Add(yt);
                    qlccv.SaveChanges();
                    return true;
                }
                else
                {
                    if(ytcheck.LoaiLuuTru==3)
                    {
                        yt.ThoiGian = DateTime.Now;
                        qlccv.SaveChanges();
                        return false;
                    }
                    
                    return false;
                }
                
            }
        }

        public static bool isYeuThichVideo(int MaProfile, int IDVideo, int LoaiLuuTru)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                YeuThich_XemGanDay ytcheck = qlccv.YeuThich_XemGanDay.Where(a => a.MaProfile == MaProfile && a.MaVideo == IDVideo && a.LoaiLuuTru == LoaiLuuTru).SingleOrDefault();
                if (ytcheck != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static bool removeYeuThichVideo(int MaProfile, int IDVideo, int LoaiLuuTru)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                YeuThich_XemGanDay ytcheck = qlccv.YeuThich_XemGanDay.Where(a => a.MaProfile == MaProfile && a.MaVideo == IDVideo && a.LoaiLuuTru == LoaiLuuTru).SingleOrDefault();
                if (ytcheck != null)
                {
                    qlccv.YeuThich_XemGanDay.Remove(ytcheck);
                    qlccv.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public static void setAddView(int ID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Video vd = qlccv.Videos.Where(v => v.MaVideo == ID).SingleOrDefault();
                vd.LuotXem = vd.LuotXem + 1;
                qlccv.SaveChanges();
            }
        }

        public static void setAddLike(int ID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Video vd = qlccv.Videos.Where(v => v.MaVideo == ID).SingleOrDefault();
                vd.Like = vd.Like + 1;
                qlccv.SaveChanges();
            }
        }

        public static void setRemoveLike(int ID)
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                Video vd = qlccv.Videos.Where(v => v.MaVideo == ID).SingleOrDefault();
                vd.Like = vd.Like - 1;
                qlccv.SaveChanges();
            }
        }
    }
}