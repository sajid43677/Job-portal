using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortal.Domain.Entitities
{
    public class JobRecommendation
    {
        public int RecommendationId { get; set; }
        public int JobSeekerId { get; set; }
        public int JobId { get; set; }
        public decimal RecommendationScore { get; set; } // Score indicating match quality
        public DateTime RecommendedDate { get; set; }

        public JobSeeker JobSeeker { get; set; }
        public Job Job { get; set; }
    }

}
