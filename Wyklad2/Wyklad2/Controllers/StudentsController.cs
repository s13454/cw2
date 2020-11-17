using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Wyklad2.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("cosInnego")]
        public string GetStudents() 
        {
            return "Jan, Andrzej, Marcin";
        }
    }
}
