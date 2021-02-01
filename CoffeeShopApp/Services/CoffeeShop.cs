using System.Collections.Generic;

namespace CoffeeShopApp.Services
{
    public class CoffeeShop : ICoffeeShopApp
    {
        public List<UsersViewModel> Users { get; } = new List<UsersViewModel>();
    }
}
