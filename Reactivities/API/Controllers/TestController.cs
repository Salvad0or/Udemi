using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace API.Controllers
{

    [ApiController]
    [Route("test2/[controller]")]
    public class TestController : ControllerBase
    {
        private DataContext _db;

        public TestController(DataContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<List<Active>> Get()
        {
            return await _db.Activity.ToListAsync();
        }
    }
}