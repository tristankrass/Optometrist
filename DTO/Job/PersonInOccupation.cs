using System;

namespace DTO.Job
{
    public class PersonInOccupation
    {
        public int PersonInOccupationId { get; set; }


        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
        
        public int OccupationId { get; set; }
        public int EyeClinicId { get; set; }
        public int PersonId { get; set; }
    }
}