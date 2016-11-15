using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanManuelMobile.Core.Models
{
    [Table("Novatus")]
    public class NovatusData
    {
        [Required]
        [Key]
        public int NovatusId { get; set; }
        public string WorkFlowName { get; set; }
        public string WorkFlowOwner { get; set; }
        public string StepName { get; set; }
        public string StepOwnerEmail { get; set; }
        public string StepOwnerName { get; set; }
        public DateTime CompletedOn { get; set; }
        public int Status { get; set; } //0-Open,1-Completed,2-Denied,
        public DateTime LastUpdated { get; set; }
        public string Remarks { get; set; }

    }
}
