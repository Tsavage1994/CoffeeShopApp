using CoffeeShopApp.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.Services
{
    public class CoffeeShopContext : DbContext
    {
        public  CoffeeShopContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<UsersDAL> Users { get; set; }
    }
}
