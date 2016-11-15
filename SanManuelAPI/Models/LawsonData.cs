using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SanManuelMobileAPI.Models
{
    [Table("Lawson")]
    public class LawsonData
    {
        [Key]
        public int LawsonId { get; set; }
        public int RequestNo { get; set; }
        public string Requester { get; set; }
        public string RequesterEmail { get; set; }
        public string Approver { get; set; }
        public string ApproverEmail { get; set; }
        public int OrderNo { get; set; }
        public string RequestDescription { get; set; }
        public DateTime RequestedDate { get; set; }
        public float EstimatedAmount { get; set; }
        public string VendorName { get; set; }
        public int VendorId { get; set; }
        public int Status { get; set; } //0-Open,1-Approve,2-Reject,3-Unrelease
        public DateTime LastUpdatedDate { get; set; }//Update date

        public string Remarks { get; set; }//For remarks




    }
}
