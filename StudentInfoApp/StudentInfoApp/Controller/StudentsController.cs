using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentInfoApp.Domain;
using StudentInfoApp.Model;

namespace StudentInfoApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
            this.studentDomain = new StudentDomain();
        }

        [HttpGet]
        public IActionResult Get(Students student)
        {
           studentDomain.Get(student);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(Students  student)
        {
            studentDomain.Add(student);
            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Students student)
        {
            studentDomain.Update(student);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int StudentId)
        {
            studentDomain.Delete(StudentId);
            return Ok();
        }
        private StudentDomain studentDomain { get; set; }
    }
}
