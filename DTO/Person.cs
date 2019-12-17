using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Person    
    {
        public int PersonId { get; set; }

        [MinLength(11), MaxLength(25)]
        public string IdCode { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        [Required(ErrorMessage="Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        public int Age { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public Gender Gender { get; set; }

        public Decimal LeftEyeStrength { get; set; }
        public Decimal RightEyeStrength { get; set; }
    }
    
    public enum Gender
    {
        Male,
        Female,
        Other,
        Unknown
    }
}