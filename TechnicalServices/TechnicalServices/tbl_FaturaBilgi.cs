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
    
    public partial class tbl_FaturaBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FaturaBilgi()
        {
            this.tbl_FaturaDetay = new HashSet<tbl_FaturaDetay>();
        }
    
        public int ID { get; set; }
        public string SERI { get; set; }
        public string SIRANO { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public string SAAT { get; set; }
        public string VERGIDAIRESI { get; set; }
        public Nullable<int> CARI { get; set; }
        public Nullable<short> PERSONEL { get; set; }
    
        public virtual tbl_Cari tbl_Cari { get; set; }
        public virtual tbl_Personel tbl_Personel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FaturaDetay> tbl_FaturaDetay { get; set; }
    }
}
