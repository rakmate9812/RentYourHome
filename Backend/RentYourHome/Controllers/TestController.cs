using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RentYourHome.Database;
using RentYourHome.Database.Models;

namespace RentYourHome.Controllers
{
    [ApiController]
    [Route("test")]
    public class TestController : Controller
    {
        private readonly AppDb _appDb;

        public TestController(AppDb appDb)
        {
            _appDb = appDb;
        }

        [HttpGet("all")]
        public ActionResult<List<Test>> GetAll()
        {
            var data = _appDb.Tests.ToList();
            return Ok(data);
        }

        [HttpPost("create")]
        public ActionResult<List<Test>> Create(string name)
        {
            var data = new Test
            {
                Name = name
            };

            _appDb.Tests.Add(data);
            _appDb.SaveChanges();

            return Ok(data);
        }
    }
}
