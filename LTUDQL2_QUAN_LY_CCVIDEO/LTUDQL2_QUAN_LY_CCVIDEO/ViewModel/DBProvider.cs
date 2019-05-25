using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
 

                return info;
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
        public static List<LoaiVideo> getLoaiVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<LoaiVideo> loai = (from v in qlccv.LoaiVideos
                                  select v).ToList();
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

    }
}
