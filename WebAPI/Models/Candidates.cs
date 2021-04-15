namespace WebAPI.Models
{
    public class Candidates
    {
        public Int64 CandidateNo { get; set; }
        public String Lastname { get; set; }
        public String Firstname { get; set; }
        public String Middlename { get; set; }
        public int Age { get; set; }
        public String Address { get; set; }
        public String Representing { get; set; }
        public byte[] CImage { get; set; }
    }
}