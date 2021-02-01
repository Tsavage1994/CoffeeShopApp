using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Models.CoffeeShopApp
{
    public class RegisterUserViewModel
    {
        [Required]
        [StringLength(35)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(35)]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Email is Invalid")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$", ErrorMessage = "Phone Number is invalid.")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
