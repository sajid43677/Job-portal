using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class JobSeekerSkill
    {
        public int JobSeekerSkillId { get; set; }
        public int JobSeekerId { get; set; }
        public int SkillId { get; set; }

        public JobSeeker JobSeeker { get; set; }
        public Skill Skill { get; set; }
    }

}
