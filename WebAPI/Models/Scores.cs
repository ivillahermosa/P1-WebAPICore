namespace WebAPI.Models
{
    public class Scores
    {
        public Int64 EventID { get; set; }
        public Int64 CandidateNo { get; set; }
        public Int64 CategoryID { get; set; }
        public int ScoreGiven { get; set; }
        public Int64 JudgeID { get; set; }
    }
}