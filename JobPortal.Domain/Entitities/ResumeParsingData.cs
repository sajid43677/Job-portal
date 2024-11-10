using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class ResumeParsingData
    {
        public int ResumeParsingId { get; set; }
        public int JobSeekerId { get; set; }
        public string ExtractedSkills { get; set; } // Serialized list of skills
        public string ExtractedExperience { get; set; }
        public string ExtractedEducation { get; set; }
        public DateTime ParseDate { get; set; }

        public JobSeeker JobSeeker { get; set; }
    }

}
