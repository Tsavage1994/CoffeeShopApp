using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Services
{
    public interface ICoffeeShopApp
    {
        List<Users> Users { get; }
    }
}
