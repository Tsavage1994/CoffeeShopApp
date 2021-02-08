using CoffeeShopApp.DALModels;
using CoffeeShopApp.Domain_Models;
using CoffeeShopApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Models.CoffeeShopApp
{
    public class InfoFormResultViewModel
    {
        public List<UsersAccountInfoViewModel> People { get; set; }
    }
}
