using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentRegistration.Model;
using StudentRegistration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterationController : ControllerBase
    {
        /*private readonly IStudentRepository _studentRepository;
        private readonly ILogger<RegisterationController> _logger;

        public RegisterationController(IStudentRepository studentRepository ,ILogger<RegisterationController> logger)
        {
            _studentRepository = studentRepository;
            _logger = logger;
        }*/

        StudentEntities con;
        DAL dl;

        public RegisterationController(StudentEntities con)
        {
            this.con = con;
            dl = new DAL(con);
        }
        // GET: api/<RegisterationController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            List<Student> ls = dl.Display();
            return ls;
        }

        // GET api/<RegisterationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RegisterationController>
        [HttpPost]
        public void Post([FromBody] Student value)
        {
            dl.Register(value);
        }

        // PUT api/<RegisterationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student value)
        {
            dl.Update(id,value);
        }

        // DELETE api/<RegisterationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dl.Delete(id);
        }
    }
}
