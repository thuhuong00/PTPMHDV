//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanTinCovidAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class TINTUC
    {
        public int MATINTUC { get; set; }
        public string TENTINTUC { get; set; }
        public string MATHELOAI { get; set; }
        public string NOIDUNG { get; set; }
        public string NOIDUNGNGAN { get; set; }
        public string TACGIA { get; set; }
        public string MANHANVIEN { get; set; }
        public System.DateTime NGAY { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual THELOAI THELOAI { get; set; }
    }
}
