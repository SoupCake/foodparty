using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment_FoodPartySystem.Models;

namespace Assignment_FoodPartySystem.Data
{
    public class Assignment_FoodPartySystemContext : DbContext
    {
        public Assignment_FoodPartySystemContext (DbContextOptions<Assignment_FoodPartySystemContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment_FoodPartySystem.Models.Contact> Contact { get; set; }

        public DbSet<Assignment_FoodPartySystem.Models.Cart> Cart { get; set; }
    }
}
