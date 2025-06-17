namespace CalendarHeatingPlanning
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }          // Name of the room
        public int HeatingCircuitId { get; set; } // Foreign key to assigned heating circuit
        public TimeSpan PreheatTime { get; set; } // Preheat time before use
    }
}
