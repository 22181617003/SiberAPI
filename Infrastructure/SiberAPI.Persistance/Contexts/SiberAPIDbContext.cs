using Microsoft.EntityFrameworkCore;
using SiberAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiberAPI.Persistance.Contexts
{
    public class SiberAPIDbContext : DbContext
    {
        public SiberAPIDbContext(DbContextOptions options) : base(options) 
        { }

        public DbSet<User> Users { get; set; }
    }
}
