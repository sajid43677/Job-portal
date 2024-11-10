using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class JobApplication
    {
        public int ApplicationId { get; set; }
        public int JobId { get; set; }
        public int JobSeekerId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public ApplicationStatus Status { get; set; } // e.g., "Pending", "Shortlisted", "Rejected", "Hired"

        public Job Job { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }

    public enum ApplicationStatus
    {
        Pending = 10,
        Shortlisted = 20,
        Hired = 30,
        Rejected = 40
    }

}
