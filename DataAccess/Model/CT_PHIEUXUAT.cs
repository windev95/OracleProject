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
    
    public partial class CT_PHIEUXUAT
    {
        public decimal MAPX { get; set; }
        public decimal MAHANGHOA { get; set; }
        public decimal SOLUONG { get; set; }
        public long TONGTIEN { get; set; }
    
        public virtual PHIEUXUAT PHIEUXUAT { get; set; }
        public virtual HANGHOA HANGHOA { get; set; }
    }
}
