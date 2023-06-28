using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers

{
    public class TestController : BaseApi
    {
        private readonly DataContext _data;

        public TestController(DataContext data)
        {
            _data = data;

        }


        [HttpGet]
        public async Task<List<Active>> GetActive()
        {
            return await _data.Activity.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<Active> GetOneActive(Guid id)
        {
            return await _data.Activity.FindAsync(id);
        }

    }
}