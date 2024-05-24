using SiberAPI.Application.Repositories;
using SiberAPI.Domain.Entities;
using SiberAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiberAPI.Persistance.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(SiberAPIDbContext context) : base(context)
        {
        }
    }
}
