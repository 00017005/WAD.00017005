namespace WAD._00017005.Models
{
    public class Event
    {
        public int Id { get; set; }  // Primary Key
        public string Name { get; set; }  // Name of the event
        public DateTime Date { get; set; }  // Date of the event
        public string Location { get; set; }  // Event location
        public string Description { get; set; }  // Event description
    }
}
