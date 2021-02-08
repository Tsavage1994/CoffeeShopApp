using CoffeeShopApp.DALModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Services
{
    public class CoffeeShopContext : IdentityDbContext
    {
        public CoffeeShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UsersAccountInfoDAL> People { get; set; }
        public DbSet<ItemDAL> Items { get; set; }
        public DbSet<UsersItemsDAL> UsersItems { get; set; }
    }
}
