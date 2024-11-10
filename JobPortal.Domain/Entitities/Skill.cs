using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }

        public ICollection<JobSkill> JobSkills { get; set; }
        public ICollection<JobSeekerSkill> JobSeekerSkills { get; set; }
    }

}
