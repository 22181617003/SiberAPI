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
    public class UserWriteRepository : WriteRepository<User>, IUserWriteRepository
    {
        public UserWriteRepository(SiberAPIDbContext context) : base(context)
        {
        }
    }
}
