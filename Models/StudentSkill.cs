namespace SEJMS.Models
{
    public class StudentSkill
    {
        public int StudentSkillId { get; set; }

        public int StudentId { get; set; }

        public int SkillId { get; set; }

        public Student? Student { get; set; }

        public Skill? Skill { get; set; }
    }
}