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
    
    public partial class GUserActivityLog
    {
        public int Id { get; set; }
        public string UalActivity { get; set; }
        public string UalRemarks { get; set; }
        public bool UalIsActivitySucceeded { get; set; }
        public string UalHostIP { get; set; }
        public string UalHostBrowserDetails { get; set; }
        public string UalHostTimeZone { get; set; }
        public Nullable<System.DateTime> UalActivityDateTime { get; set; }
        public string UalUserId { get; set; }
        public string UalActionById { get; set; }
        public int UalCompanyId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual GCompany GCompany { get; set; }
    }
}