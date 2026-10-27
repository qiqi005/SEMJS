namespace SEJMS.Models
{
    public class StudentInterest
    {
        public int StudentInterestId { get; set; }


    public int StudentId { get; set; }

        public int InterestId { get; set; }

        public Student? Student { get; set; }

        public Interest? Interest { get; set; }
    }


}
