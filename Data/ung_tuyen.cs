//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ung_tuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ung_tuyen()
        {
            this.ung_tuyen_thanh_cong = new HashSet<ung_tuyen_thanh_cong>();
        }
    
        public int id { get; set; }
        public int id_nguoi_tim_viec { get; set; }
        public int id_cong_viec { get; set; }
        public Nullable<System.DateTime> ngay_ung_tuyen { get; set; }
    
        public virtual cong_viec cong_viec { get; set; }
        public virtual nguoi_tim_viec nguoi_tim_viec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ung_tuyen_thanh_cong> ung_tuyen_thanh_cong { get; set; }
    }
}
