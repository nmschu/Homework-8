using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Homework8.Models
{
    public class PetContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }

    }
}