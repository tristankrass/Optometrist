using System;

namespace DTO.Clinic
{
    public class PersonInRoom
    {
        public int PersonInRoomId { get; set; }
        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }

        public int RoomID { get; set; }
    }
}