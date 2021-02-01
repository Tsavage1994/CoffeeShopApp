using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeShopApp.DALModels;
using CoffeeShopApp.Models;
using CoffeeShopApp.Models.CoffeeShopApp;
using CoffeeShopApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApp.Controllers
{
    public class CoffeeShopAppController : Controller
    {
        private readonly ICoffeeShopApp _coffeeShopApp;
        private readonly CoffeeShopContext _coffeeShopContext;
        
        public CoffeeShopAppController(ICoffeeShopApp coffeeShopApp, CoffeeShopContext coffeeShopContext)
        {
            _coffeeShopApp = coffeeShopApp;
            _coffeeShopContext = coffeeShopContext;
        }

        public IActionResult RegisterUser()
        {
            return View();
        }

        public IActionResult RegistrationResults(RegisterUserViewModel model)
        {
            var user = new UsersDAL();
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Email = model.Email;
            user.PasswordHash = model.Password;
            user.DateOfBirth = model.DateOfBirth;
            user.PhoneNumber = model.PhoneNumber;
            user.PasswordHash = model.ConfirmPassword;

            _coffeeShopContext.Users.Add(user);
            _coffeeShopContext.SaveChanges();
         
            return RegistrationResultsView();
        }
        public IActionResult MakeNewUser(UsersViewModel users, int id)
        {
            var user = GetUserWhereIdIsFirstOrDefault(id);

            var usersDAL = _coffeeShopApp.Users.FirstOrDefault(usersDAL => users.UserID == user.UserID);
            usersDAL.FirstName = users.FirstName;
            usersDAL.LastName = users.LastName;
            usersDAL.DateOfBirth = users.DateOfBirth;
            usersDAL.PhoneNumber = users.PhoneNumber;
            usersDAL.Email = users.Email;
            usersDAL.PasswordHash = users.PasswordHash;

            _coffeeShopContext.SaveChanges();

            return RegistrationResultsView();
        }
        private UsersViewModel GetUserWhereIdIsFirstOrDefault(int id)
        {
            UsersDAL usersDAL = _coffeeShopContext.Users.Where(user => user.UserID == id).FirstOrDefault();

            UsersViewModel user = new UsersViewModel();
            user.UserID = usersDAL.UserID;
            user.FirstName = usersDAL.FirstName;
            user.LastName = usersDAL.LastName;
            user.DateOfBirth = usersDAL.DateOfBirth;
            user.Email = usersDAL.Email;
            user.PhoneNumber = usersDAL.PhoneNumber;
            user.PasswordHash = usersDAL.PasswordHash;
            return user;

        }
        private IActionResult RegistrationResultsView()
        {
            var viewModel = new RegistrationResultsViewModel();
            var users = _coffeeShopContext.Users.ToList();

            var userViewModelList = users.Select(usersDAL => new UsersViewModel()
            {
                UserID = usersDAL.UserID,
                FirstName = usersDAL.FirstName,
                LastName = usersDAL.LastName,
                Email = usersDAL.Email,
                PasswordHash = usersDAL.PasswordHash,
                DateOfBirth = usersDAL.DateOfBirth,
                PhoneNumber = usersDAL.PhoneNumber
            })  .ToList();

            viewModel.Users = userViewModelList;
            return View("Registratoin Results", viewModel);
        }
    }
}
