//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vodafone_SOS_WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RCommissionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RCommissionType()
        {
            this.LClaims = new HashSet<LClaim>();
            this.LClaims1 = new HashSet<LClaim>();
            this.LClaims2 = new HashSet<LClaim>();
        }
    
        public int Id { get; set; }
        public int RctCompanyId { get; set; }
        public string RctName { get; set; }
        public string RctDescription { get; set; }
        public Nullable<bool> RctIsActive { get; set; }
    
        public virtual GCompany GCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LClaim> LClaims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LClaim> LClaims1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LClaim> LClaims2 { get; set; }
    }
}
