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
    
    public partial class The
    {
        public The()
        {
            this.TaiKhoans = new HashSet<TaiKhoan>();
            this.ThanhToans = new HashSet<ThanhToan>();
        }
    
        public string IDCard { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Code { get; set; }
    
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}
