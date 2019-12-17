using System;
using System.Collections.Generic;

namespace DTO.Clinic
{
    public class EyeClinic
    {
        public int EyeClinicId { get; set; }
        public DateTime DateTimeBeginning { get; set; }
        public DateTime DateTimeEnding { get; set; }
        
        public IList<ClinicInCity> EyeClinicsInCitiesCollection { get; set; }
    }
}