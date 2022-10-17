using API_Task.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Task.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class TaskController : ControllerBase
    {
        [HttpPost("Create")]
        public IActionResult Create(TaskModels task)
        {

        }


        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }
    }
}
