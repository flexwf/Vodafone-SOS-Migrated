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
    
    public partial class RRejectionReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RRejectionReason()
        {
            this.LClaims = new HashSet<LClaim>();
        }
    
        public int Id { get; set; }
        public string RrrReason { get; set; }
        public string RrrDescription { get; set; }
        public int RrrCompanyId { get; set; }
        public Nullable<bool> RrrIsActive { get; set; }
    
        public virtual GCompany GCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LClaim> LClaims { get; set; }
    }
}
