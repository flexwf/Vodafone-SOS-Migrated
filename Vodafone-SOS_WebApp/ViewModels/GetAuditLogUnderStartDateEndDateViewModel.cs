﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Vodafone_SOS_WebApp.ViewModels
{
    public partial class GetAuditLogUnderStartDateEndDateViewModel
    {
        public int CompanyId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}