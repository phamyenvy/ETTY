//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTUDQL2_QUAN_LY_CCVIDEO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Profile
    {
        public Profile()
        {
            this.PlayLists = new HashSet<PlayList>();
            this.YeuThich_XemGanDay = new HashSet<YeuThich_XemGanDay>();
        }
    
        public int MaProfile { get; set; }
        public string TenHienThi { get; set; }
        public string AvatarLink { get; set; }
        public Nullable<int> TaiKhoan { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual ICollection<PlayList> PlayLists { get; set; }
        public virtual TaiKhoan TaiKhoan1 { get; set; }
        public virtual ICollection<YeuThich_XemGanDay> YeuThich_XemGanDay { get; set; }
    }
}
