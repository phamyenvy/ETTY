using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LTUDQL2_QUAN_LY_CCVIDEO.Model
{
    public class VideoInfo : DependencyObject
    {
        public static readonly DependencyProperty IDProperty;
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PathProperty;
        public static readonly DependencyProperty PathVideoProperty;
        public static readonly DependencyProperty PathVideoPhimProperty;

        public static readonly DependencyProperty DescriptionProperty;
        public static readonly DependencyProperty ViewsProperty;
        static VideoInfo()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(VideoInfo), new PropertyMetadata("New Video"));
            IDProperty = DependencyProperty.Register("ID", typeof(string), typeof(VideoInfo), new PropertyMetadata("New ID"));
            PathProperty = DependencyProperty.Register("Path", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"C:\Users\Vi Vu\Desktop\Video.mp4"));
            PathVideoProperty = DependencyProperty.Register("PathVideo", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"C:\Users\Vi Vu\Desktop\Video.mp4"));
            PathVideoPhimProperty = DependencyProperty.Register("PathVideoPhim", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"C:\Users\Vi Vu\Desktop\Video.mp4"));

            DescriptionProperty = DependencyProperty.Register("Description", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"New decription"));
            ViewsProperty = DependencyProperty.Register("Views", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"New views"));
        }

        public string ID
        {
            get
            {
                return (string)GetValue(IDProperty);
            }
            set
            {
                SetValue(IDProperty, value);
            }
        }
        public string Views
        {
            get
            {
                return (string)GetValue(ViewsProperty);
            }
            set
            {
                SetValue(ViewsProperty, value);
            }
        }

        public string Title
        {
            get
            {
                return (string)GetValue(TitleProperty);
            }
            set
            {
                SetValue(TitleProperty, value);
            }
        }
        public string Path
        {
            get
            {
                return (string)GetValue(PathProperty);
            }
            set
            {
                SetValue(PathProperty, value);
            }
        }

        public string PathVideo
        {
            get
            {
                return (string)GetValue(PathVideoProperty);
            }
            set
            {
                SetValue(PathVideoProperty, value);
            }
        }
        public string PathVideoPhim
        {
            get
            {
                return (string)GetValue(PathVideoPhimProperty);
            }
            set
            {
                SetValue(PathVideoPhimProperty, value);
            }
        }

        public string Description
        {
            get
            {
                return (string)GetValue(DescriptionProperty);
            }
            set
            {
                SetValue(DescriptionProperty, value);
            }
        }
    }
}
