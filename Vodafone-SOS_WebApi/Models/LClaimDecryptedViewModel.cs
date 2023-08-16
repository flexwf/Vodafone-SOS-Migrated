﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vodafone_SOS_WebApi.Models
{
    public partial class LClaimDecryptedViewModel
    {
        public int Id { get; set; }

        public int LcCompanyId { get; set; }

        public string LcCreatedById { get; set; }

        public Nullable<int> LcBrandId { get; set; }

        public string ParameterCarrier { get; set; }
        public bool LcCreatedByForm { get; set; }
        public Nullable<int> LcActivityTypeId { get; set; }

        public Nullable<int> LcCommissionTypeId { get; set; }
        public string LcAllocatedToId { get; set; }
        public string LcAllocatedById { get; set; }
        public Nullable<int> LcRejectionReasonId { get; set; }
        public Nullable<int> LcPaymentCommissionTypeId { get; set; }
        public string LcApprovedById { get; set; }
        public string LcSentForApprovalById { get; set; }
        public string LcWithdrawnById { get; set; }
        public string LcRejectedById { get; set; }

        public Nullable<int> LcDeviceTypeId { get; set; }

        public long LcClaimId { get; set; }

        public Nullable<System.DateTime> LcConnectionDate { get; set; }

        public Nullable<System.DateTime> LcOrderDate { get; set; }

        public string LcMSISDN { get; set; }

        public string LcBAN { get; set; }

        public string LcOrderNumber { get; set; }


        public string LcCustomerName { get; set; }

        public Nullable<int> LcProductCodeId { get; set; }

        public decimal LcExpectedCommissionAmount { get; set; }

        public string LcIMEI { get; set; }

        public bool LcIsDuplicateClaim { get; set; }

        public string LcDuplicateClaimDetails { get; set; }

        public Nullable<System.DateTime> LcAllocationDate { get; set; }

        public bool LcIsReclaim { get; set; }

        public Nullable<decimal> LcAlreadyPaidAmount { get; set; }

        public Nullable<System.DateTime> LcAlreadyPaidDate { get; set; }

        public string LcAlreadyPaidDealer { get; set; }

        public string LcReasonNonAutoPayment { get; set; }

        public string LcClawbackPayeeCode { get; set; }

        public Nullable<decimal> LcClawbackAmount { get; set; }

        public Nullable<System.DateTime> LcSentForApprovalDate { get; set; }

        public Nullable<System.DateTime> LcApprovalDate { get; set; }

        public Nullable<System.DateTime> LcPaymentDate { get; set; }

        public Nullable<System.DateTime> LcLastReclaimDate { get; set; }

        public Nullable<System.DateTime> LcWithdrawnDate { get; set; }

        public Nullable<System.DateTime> LcRejectionDate { get; set; }

        public Nullable<decimal> LcPaymentAmount { get; set; }

        public string A01 { get; set; }

        public string A02 { get; set; }

        public string A03 { get; set; }

        public string A04 { get; set; }

        public string A05 { get; set; }

        public string A06 { get; set; }

        public string A07 { get; set; }

        public string A08 { get; set; }

        public string A09 { get; set; }

        public string A10 { get; set; }


        public Nullable<int> LcPaymentBatchNumber { get; set; }
        public Nullable<int> LcClaimBatchNumber { get; set; }
        public Nullable<System.DateTime> LcCreatedDateTime { get; set; }
        public string WFRequesterId { get; set; }
        public string WFAnalystId { get; set; }
        public string WFManagerId { get; set; }
        public Nullable<int> WFOrdinal { get; set; }
        public string WFCurrentOwnerId { get; set; }
        public string WFStatus { get; set; }
        public string WFType { get; set; }
        public string WFRequesterRoleId { get; set; }
        public int WFCompanyId { get; set; }

        public string WFComments { get; set; }

        public int LcPayeeId { get; set; }

        public string LcPayeeCode { get; set; }
        
        public string LcCommissionPeriod { get; set; }
        
        public int? LcParentPayeeId { get; set; }

        public string RChannel { get; set; }
    }
}