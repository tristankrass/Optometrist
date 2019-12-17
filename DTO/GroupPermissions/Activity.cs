using System;

namespace DTO.GroupPermissions
{
    public class Activity
    {

        public int ActivityId { get; set; }
        public string NameOfActivity { get; set; }

        public string ActivityCode { get; set; }
        public DateTime DateTimeBeginning { get; set; }
        public DateTime DateTimeEnding { get; set; }
    }
}