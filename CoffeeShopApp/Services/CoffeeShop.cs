using CoffeeShopApp.Domain_Models;
using System.Collections.Generic;

namespace CoffeeShopApp.Services
{
    public class CoffeeShop : ICoffeeShopApp
    {
        public List<UsersAccountInfoViewModel> People { get; } = new List<UsersAccountInfoViewModel>();
    }
}
