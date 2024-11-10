using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class JobSkill
    {
        public int JobSkillId { get; set; }
        public int JobId { get; set; }
        public int SkillId { get; set; }

        public Job Job { get; set; }
        public Skill Skill { get; set; }
    }

}
