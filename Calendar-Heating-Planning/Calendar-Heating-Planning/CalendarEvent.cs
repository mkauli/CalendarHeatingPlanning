namespace CalendarHeatingPlanning
{
    public class CalendarEvent
    {
        public string Id { get; set; }                // Unique event identifier
        public string RoomName { get; set; }          // Name of the room (from iCal)
        public DateTime Start { get; set; }           // Event start time
        public DateTime End { get; set; }             // Event end time
        public string Summary { get; set; }           // Event description/title
    }
}
