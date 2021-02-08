using System.Collections.Generic;
using System.Linq;
using CoffeeShopApp.DALModels;
using CoffeeShopApp.Domain_Models;
using CoffeeShopApp.Models.CoffeeShopApp;
using CoffeeShopApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApp.Controllers
{
    [Authorize]
    public class CoffeeShopAppController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICoffeeShopApp _coffeeShopApp;
        private readonly CoffeeShopContext _coffeeShopContext;

        public CoffeeShopAppController(
            ICoffeeShopApp coffeeShopApp, 
            CoffeeShopContext coffeeShopContext, 
            UserManager<IdentityUser> userManger)
        {
            _coffeeShopApp = coffeeShopApp;
            _coffeeShopContext = coffeeShopContext;
            _userManager = userManger;
        }

        public IActionResult AddUsersInfo()
        {
            var userName = _userManager.GetUserName(User);

            return View();
        }
        public IActionResult InfoFormResults(AddUsersInfoViewModel model)
        {
            var errors = ModelState.Select(kvp => kvp.Value.Errors).ToList();

            if (ModelState.IsValid)
            {
                var person = new UsersAccountInfoDAL();
                person.FirstName = model.FirstName;
                person.LastName = model.LastName;
                person.PhoneNumber = model.PhoneNumber;
                person.DateOfBirth = model.DateOfBirth;

                _coffeeShopContext.People.Add(person);
                _coffeeShopContext.SaveChanges();


                return FormResultView();
            }

            return View("Error");
        }
        public IActionResult UpdateInfo(int id)
        {
            var person = GetInfoWhereIdIsFirstOrDefault(id);

            var model = new UpdateInfoViewModel();
            var oldInfo = new AddUsersInfoViewModel();

            model.OldInfo = oldInfo;
            oldInfo.FirstName = person.FirstName;
            oldInfo.LastName = person.LastName;
            oldInfo.PhoneNumber = person.PhoneNumber;
            oldInfo.DateOfBirth = person.DateOfBirth;

            return View(model);
        }

        public IActionResult UpdateInfoResult(UpdateInfoViewModel model, int id)
        {
            var person = GetInfoWhereIdIsFirstOrDefault(id);

            var usersAccountDAL = _coffeeShopContext
                .People
                .FirstOrDefault(registeredUserDAL => registeredUserDAL.UserID == person.UserID);

            usersAccountDAL.FirstName = model.NewInfo.FirstName;
            usersAccountDAL.LastName = model.NewInfo.LastName;
            usersAccountDAL.PhoneNumber = model.NewInfo.PhoneNumber;
            usersAccountDAL.DateOfBirth = model.NewInfo.DateOfBirth;

            _coffeeShopContext.SaveChanges();

            return FormResultView();
        }
        public IActionResult DeleteInfo(int id)
        {
            var person = GetInfoWhereIdIsFirstOrDefault(id);

            var usersAccountDAL = _coffeeShopContext
               .People
               .FirstOrDefault(usersAccountDAL => usersAccountDAL.UserID == person.UserID);

            _coffeeShopContext.People.Remove(usersAccountDAL);

            _coffeeShopContext.SaveChanges();

            return FormResultView();
        }
        private UsersAccountInfoViewModel GetInfoWhereIdIsFirstOrDefault(int id)
        {
              var registeredUserDAL = _coffeeShopContext.People
                .Where(person => person.UserID == id)
                .FirstOrDefault();

            var person = new UsersAccountInfoViewModel();
            person.UserID = registeredUserDAL.UserID;
            person.FirstName = registeredUserDAL.FirstName;
            person.LastName = registeredUserDAL.LastName;
            person.PhoneNumber = registeredUserDAL.PhoneNumber;
            person.DateOfBirth = registeredUserDAL.DateOfBirth;
            return person;
        }
        private IActionResult FormResultView()
        {
            //  Dog View           DogDAL
            // View Layer <====> Data Acess Layer

            var viewModel = new InfoFormResultViewModel();

            var peopleDAL = _coffeeShopContext.People.ToList();

            // Mapping DogDAL to dog View
            var usersInfoViewModelList = peopleDAL
                .Select(personDAL => new UsersAccountInfoViewModel()
                {
                    UserID = personDAL.UserID,
                    FirstName = personDAL.FirstName, 
                    LastName = personDAL.LastName,  
                    PhoneNumber = personDAL.PhoneNumber, 
                    DateOfBirth = personDAL.DateOfBirth})
                .ToList();

            viewModel.People = usersInfoViewModelList;

            return View("InfoFormResults", viewModel);
        }
    }
}
