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
    
    public partial class LDelegation
    {
        public int Id { get; set; }
        public int LdCompanyId { get; set; }
        public string LdDelegationFromId { get; set; }
        public string LdDelegationToId { get; set; }
        public System.DateTime LdDelegationDate { get; set; }
        public System.DateTime LdDelegationStartDate { get; set; }
        public Nullable<System.DateTime> LdDelegationEndDate { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual GCompany GCompany { get; set; }
    }
}