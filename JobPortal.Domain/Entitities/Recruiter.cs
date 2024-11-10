using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class Recruiter
    {
        public int RecruiterId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }

        public User User { get; set; }
        public ICollection<Job> Jobs { get; set; }
    }

}
