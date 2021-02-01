using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoffeeShopApp.Services
{
    public class UsersViewModel
    {
        /* private object _coffeeShopApp;

        public Users(RegisterUserViewModel model)
        {
            var user = new Users(model);
            _coffeeShopApp.Users.add(user);
            var viewModel = new RegisterationResultsViewModel();
            viewModel.Users = _coffeeShopApp.Users;
            return View(viewModel);
        }*/
        public int UserID { get; set; }
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
        [RegularExpression(@"^([A-z|0-9]{5,30})@([A-z|0-9]{5,10})\.([A-z]{2,3})$", ErrorMessage = "Email is Invalid")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^((\d{3}-)|(\(\d{3}\)(-| )))?\d{3}-\d{4}$", ErrorMessage = "Phone Number is invalid.")]
        public string PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }
        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match")]
        public string ConfirmPassword { get; set; }
    }
}
