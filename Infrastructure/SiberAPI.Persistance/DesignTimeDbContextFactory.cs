using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SiberAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiberAPI.Persistance
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SiberAPIDbContext>
    {
        public SiberAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<SiberAPIDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
