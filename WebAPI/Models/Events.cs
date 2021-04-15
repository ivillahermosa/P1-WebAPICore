namespace WebAPI.Models
{
    public class Event
    {
        public Int64 EventID { get; set; }

        public String EventName { get; set; }

        public DateTime EventDate { get; set; }

        public String EventVenue { get; set; }
    }
}