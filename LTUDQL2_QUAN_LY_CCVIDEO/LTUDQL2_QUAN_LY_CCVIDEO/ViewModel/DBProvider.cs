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
                                  select v).Take(15).ToList();

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
        public static List<VideoInfo> getMainVideo()
        {
            using (var qlccv = new QuanLyCCVEntities())
            {
                List<Video> vd = (from v in qlccv.Videos
                                  orderby v.LuotXem descending
                                  select v).Take(1).ToList();

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
                                  select v).Take(15).ToList();

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
                                                  select vd).ToList()==null)
                {
                    return null;
                }

                List<Video> video = (from v in qlccv.YeuThich_XemGanDay
                                                  join vd in qlccv.Videos on v.MaVideo equals vd.MaVideo
                                                  where v.MaProfile == pf.MaProfile && v.LoaiLuuTru == 1
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


    }
}
