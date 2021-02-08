using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopApp.DALModels
{
    public class UsersItemsDAL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserItemID { get; set; }

        [ForeignKey("User")]
        public string UserID { get; set; }
        public IdentityUser User { get; set; }
    }
}
