//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechnicalServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_UrunKabul
    {
        public int ISLEMID { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public Nullable<System.DateTime> GELISTARIHI { get; set; }
        public Nullable<System.DateTime> CIKISTARIHI { get; set; }
        public string URUNSERINO { get; set; }
    
        public virtual tbl_Cari tbl_Cari { get; set; }
        public virtual tbl_Personel tbl_Personel { get; set; }
    }
}