using Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IService<AppointmentDto> service;
        public AppointmentController(IService<AppointmentDto> service)
        {
            this.service = service;
        }
        // GET: api/<AppointmentController>
        [HttpGet]
        public List<AppointmentDto> Get()
        {
            return service.GetAll();
        }

        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public AppointmentDto Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<AppointmentController>
        [HttpPost]
        public AppointmentDto Post([FromBody] AppointmentDto value)
        {
            return service.Add(value);
        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public AppointmentDto Put(int id, [FromBody] AppointmentDto value)
        {
            return service.Update(id, value);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
