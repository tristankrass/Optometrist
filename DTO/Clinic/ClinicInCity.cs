using System;

namespace DTO.Clinic
{
    public class ClinicInCity
    {
        public int ClinicInCityId { get; set; }
        public DateTime DateTimeBeginning { get; set; }
        public DateTime DateTimeEnding { get; set; }
        public EyeClinic EyeClinicId { get; set; }
        public City CityId { get; set; }
    }
}