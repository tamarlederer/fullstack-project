using Common.Dto;
using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IService<DoctorDto> service;
        public DoctorController(IService<DoctorDto> service)
        {
            this.service = service;
        }
        // GET: api/<DoctorController>
        [HttpGet]
        public List<DoctorDto> Get()
        {
            return service.GetAll();
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public DoctorDto Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public DoctorDto Post([FromBody] DoctorDto value)
        {
            return service.Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public DoctorDto Put(int id, [FromBody] DoctorDto value)
        {
            return service.Update(id, value);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
