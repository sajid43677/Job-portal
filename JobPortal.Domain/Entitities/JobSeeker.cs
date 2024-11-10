using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class JobSeeker
    {
        public int JobSeekerId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public ExperienceLevel ExperienceLevel { get; set; } // e.g., "Entry", "Mid", "Senior"
        public string LinkedInProfile { get; set; }
        public string ResumeFilePath { get; set; }

        public User User { get; set; }
        public ICollection<JobSeekerSkill> JobSeekerSkills { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }
        public ICollection<ResumeParsingData> ResumeParsingData { get; set; }
        public ICollection<JobRecommendation> JobRecommendations { get; set; }
    }

}
