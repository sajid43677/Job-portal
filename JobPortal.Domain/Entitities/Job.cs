using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class Job
    {
        public int JobId { get; set; }
        public int RecruiterId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public EmploymentType EmploymentType { get; set; } // e.g., "Full-time", "Part-time"
        public ExperienceLevel ExperienceLevel { get; set; } // e.g., "Entry", "Mid", "Senior"
        public string SalaryRange { get; set; }
        public DateTime DatePosted { get; set; }
        public bool IsActive { get; set; }

        public Recruiter Recruiter { get; set; }
        public ICollection<JobSkill> JobSkills { get; set; }
        public ICollection<JobApplication> JobApplications { get; set; }
    }

    public enum EmploymentType
    {
        FullTime = 10,
        PartTime = 20
    }

    public enum ExperienceLevel
    {
        Entry = 10,
        Mid = 20,
        Senior = 30
    }

}
