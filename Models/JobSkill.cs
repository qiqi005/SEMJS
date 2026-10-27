using Microsoft.EntityFrameworkCore;

namespace SEJMS.Models
{
    [Index(nameof(JobId), nameof(SkillId), IsUnique = true)]
    public class JobSkill
    {
        public int JobSkillId { get; set; }

        public int JobId { get; set; }

        public int SkillId { get; set; }

        public Job? Job { get; set; }

        public Skill? Skill { get; set; }
    }
}