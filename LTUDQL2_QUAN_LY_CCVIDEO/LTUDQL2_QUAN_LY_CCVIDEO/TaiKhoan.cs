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
    
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            this.Profiles = new HashSet<Profile>();
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public int MaTaiKhoan { get; set; }
        public string TenTaiKhoan { get; set; }
        public int LoaiTaiKhoan { get; set; }
        public Nullable<int> CapDo { get; set; }
        public Nullable<System.DateTime> NgayHetHan { get; set; }
        public string Password { get; set; }
        public string TenHienThi { get; set; }
        public int MaXacNhan { get; set; }
        public string IDThe { get; set; }
    
        public virtual CapDoTaiKhoan CapDoTaiKhoan { get; set; }
        public virtual ICollection<Profile> Profiles { get; set; }
        public virtual The The { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
