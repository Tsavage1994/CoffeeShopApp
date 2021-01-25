using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApp.Models;
using CoffeeShopApp.Models.CoffeeShopApp;
using CoffeeShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class CoffeeShopAppController : Controller
    {
        private readonly ICoffeeShopApp _coffeeShopApp;
        
        public CoffeeShopAppController(ICoffeeShopApp coffeeShopApp)
        {
            _coffeeShopApp = coffeeShopApp;
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        public IActionResult RegistrationResults(RegisterUserViewModel model)
        {
            var user = new Users();
            user.UsersFirstName = model.UsersFirstName;
            user.UsersLastName = model.UsersLastName;
            user.Email = model.Email;
            user.Password = model.Password;
            user.UsersDateOfBirth = model.UsersDateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            user.ConfirmPassword = model.ConfirmPassword;

            _coffeeShopApp.Users.Add(user);

            var viewModel = new RegistrationResultsViewModel();
            viewModel.Users = _coffeeShopApp.Users;
            return View(viewModel);
        }
    }
}
