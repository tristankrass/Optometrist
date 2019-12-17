using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO.Clinic
{
    public class City
    {
        public int CityId { get; set; }
        
        [Required][MinLength(2), MaxLength(256)]
        public string Name { get; set; }

        public IList<ClinicInCity> ClinicInCitiesCollection { get; set; }
    }
}