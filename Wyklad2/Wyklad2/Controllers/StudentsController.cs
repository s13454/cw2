using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wyklad2.Models;

namespace Wyklad2.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public IActionResult GetStudents(int id) 
        {

            var st = new Student();
            st.IdStudent = id;
            st.FirstName = "Jan";
            st.LastName = "Kowalski";


            return Ok(st);
        }
    }
}
