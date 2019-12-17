using System;

namespace DTO.Clinic
{
    public class Room
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
        public Decimal? RoomSize { get; set; }
        
        public DateTime DateTimeBeginning { get; set; }
        public DateTime DateTimeEnding { get; set; }
    }
}