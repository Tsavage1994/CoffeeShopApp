using System.Collections.Generic;

namespace CoffeeShopApp.Services
{
    public class CoffeeShop : ICoffeeShopApp
    {
        public List<Users> Users { get; } = new List<Users>();
    }
}
