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
    
    public partial class MDocumentSetsPayee
    {
        public int Id { get; set; }
        public int MdspPayeeId { get; set; }
        public int MdspDocumentSetId { get; set; }
        public string AttachmentId { get; set; }
    
        public virtual LDocumentSet LDocumentSet { get; set; }
        public virtual LPayee LPayee { get; set; }
    }
}