using Microsoft.AspNetCore.Mvc;
using SiberAPI.Application.Repositories;

namespace SiberAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : Controller
    {
        readonly private IUserWriteRepository _userWriteRepository;
        readonly private IUserReadRepository _userReadRepository;
        public UsersController(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }
        [HttpGet]
        public async void Get() 
        {
            await _userWriteRepository.AddRangeAsync(new()
            {
                new() {Id = Guid.NewGuid(), Username = "ahmet", Password = "12345",Point = 0 },
                new() {Id = Guid.NewGuid(), Username = "eray", Password = "12345",Point = 0 },
                new() {Id = Guid.NewGuid(), Username = "yigit", Password = "12345",Point = 0 }
            });
            var count = await _userWriteRepository.SaveAsync();
        }
    }
}
