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
    
    public partial class LDropDown
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LDropDown()
        {
            this.LCompanySpecificColumns = new HashSet<LCompanySpecificColumn>();
            this.LDropDownValues = new HashSet<LDropDownValue>();
        }
    
        public int Id { get; set; }
        public int LdCompanyId { get; set; }
        public string LdName { get; set; }
        public string LdDescription { get; set; }
    
        public virtual GCompany GCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LCompanySpecificColumn> LCompanySpecificColumns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LDropDownValue> LDropDownValues { get; set; }
    }
}