using API_Task.Context;
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
        private readonly TaskContext _taskContext;

        public TaskController(TaskContext context)
        {
            _taskContext = context;
        }

        [HttpPost("Create")]
        public IActionResult Create(TaskModels task)
        {
            _taskContext.Add(task);
            _taskContext.SaveChanges();
            return Ok(task);
        }


        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            
            return Ok();
        }
    }
}
