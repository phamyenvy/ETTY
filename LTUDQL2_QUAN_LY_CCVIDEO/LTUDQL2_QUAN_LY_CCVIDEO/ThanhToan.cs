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
    
    public partial class ThanhToan
    {
        public int MaThanhToan { get; set; }
        public string TenThanhToan { get; set; }
        public Nullable<int> TaiKhoan { get; set; }
        public Nullable<int> CapDoMua { get; set; }
        public string IDThe { get; set; }
        public Nullable<System.DateTime> NgayThanhToan { get; set; }
        public Nullable<int> SoTien { get; set; }
    
        public virtual TaiKhoan TaiKhoan1 { get; set; }
        public virtual The The { get; set; }
    }
}
