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
        public static readonly DependencyProperty TitleProperty;
        public static readonly DependencyProperty PathProperty;
        public static readonly DependencyProperty DescriptionProperty;
        static VideoInfo()
        {
            TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(VideoInfo), new PropertyMetadata("New Video"));
            PathProperty = DependencyProperty.Register("Path", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"C:\Users\Vi Vu\Desktop\Video.mp4"));
            DescriptionProperty = DependencyProperty.Register("Description", typeof(string), typeof(VideoInfo), new PropertyMetadata(@"New decription"));
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
