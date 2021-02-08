using CoffeeShopApp.Domain_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Services
{
    public interface ICoffeeShopApp
    {
        List<UsersAccountInfoViewModel> People { get; }
    }
}
