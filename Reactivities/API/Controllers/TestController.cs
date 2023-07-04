using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers

{
    public class TestController : BaseApi
    {
        [HttpGet]
        public async Task<List<Active>> GetActive()
        {
            return await Mediator.Send(new ReturnList.Query());   
        }

        [HttpGet("{id}")]

        public async Task<Active> GetOneActive(Guid id)
        {
            return await Mediator.Send(new Details.Query{Id = id});
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Active active)
        {
            return Ok(await Mediator.Send(new Create.Command{Active = active}));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditeActivity(Guid id, Active active)
        {
            
            return Ok(await Mediator.Send(new Edit.Command{Active = active}));
        }

    }
}