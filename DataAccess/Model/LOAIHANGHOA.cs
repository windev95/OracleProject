//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIHANGHOA
    {
        public LOAIHANGHOA()
        {
            this.HANGHOA = new HashSet<HANGHOA>();
        }
    
        public decimal MALOAIHANG { get; set; }
        public string TENLOAIHANG { get; set; }
    
        public virtual ICollection<HANGHOA> HANGHOA { get; set; }
    }
}
