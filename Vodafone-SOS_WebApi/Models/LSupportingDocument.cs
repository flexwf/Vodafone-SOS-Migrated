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
    
    public partial class LSupportingDocument
    {
        public int Id { get; set; }
        public string LsdCreatedById { get; set; }
        public string LsdUpdatedById { get; set; }
        public string LsdFileName { get; set; }
        public string LsdFilePath { get; set; }
        public string LsdEntityType { get; set; }
        public int LsdEntityId { get; set; }
        public System.DateTime LsdCreatedDateTime { get; set; }
        public System.DateTime LsdUpdatedDateTime { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
    }
}
