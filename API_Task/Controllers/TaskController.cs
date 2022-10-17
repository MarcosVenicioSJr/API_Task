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

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(int id)
        {
            var task = _taskContext.tasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }

            _taskContext.tasks.Remove(task);
            return NoContent();

        }

        [HttpPut("PutTask/{id}")]
        public IActionResult PutTask(int id, TaskModels task)
        {
            var taskPut = _taskContext.tasks.Find(id);

            if (task == null)
            {
                return NotFound();
            }

            taskPut.Title = task.Title;
            taskPut.Description = task.Description;
            taskPut.Status = task.Status;
            taskPut.Date = task.Date;

            _taskContext.tasks.Update(taskPut);
            _taskContext.SaveChanges();

            return Ok(taskPut);
        }


        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var task = _taskContext.tasks.Find(id);
            return Ok(task);
        }
    }
}
