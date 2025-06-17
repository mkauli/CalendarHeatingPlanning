namespace CalendarHeatingPlanning
{
    public class HeatingCircuit
    {
        public int Id { get; set; }
        public string Name { get; set; }              // Name of the heating circuit
        public string KnxGroupAddress { get; set; }   // KNX group address for switching
        public List<int> RoomIds { get; set; }        // IDs of rooms belonging to this circuit
        public bool IsOn { get; set; }                // Current state (on/off)
    }
}
