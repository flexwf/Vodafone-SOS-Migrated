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
    
    public partial class LPayeeParent
    {
        public int Id { get; set; }
        public int LppPayeeId { get; set; }
        public int LppParentPayeeId { get; set; }
        public System.DateTime LppEffectiveStartDate { get; set; }
        public Nullable<System.DateTime> LppEffectiveEndDate { get; set; }
    
        public virtual LPayee LPayee { get; set; }
        public virtual LPayee LPayee1 { get; set; }
    }
}
