using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; // Not mapped 

namespace DbOutOfNames.Models
{
    public class Person
    {
        [Key]

        [Required(ErrorMessage = "Please enter an E-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string First { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string Last { get; set; }

        [Required(ErrorMessage = "Please enter a country.")]
        public string CountryId { get; set; }
        public Country Country { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(18, ErrorMessage = "{0} must be at least {2} characters long.", MinimumLength = 8)]
        [RegularExpression(@"^(?=.*([a-zA-Z])(?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage = "Password must start with a letter, contain an upper and lower case letter and a number.")]
        //[DataType(DataType.Password)]                       // Will stop password from being plain text
        //[Display(Name = "Password")]
        public string Password { get; set; }

        [NotMapped] // Does not effect with your database
        [Required(ErrorMessage = "Re-type password field required")]
        [Compare("Password", ErrorMessage = "Both password fields do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
