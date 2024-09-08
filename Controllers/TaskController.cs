using Amana_Api.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Amana_Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly TaskContext _taskContext;
        public TaskController()
        {
            _taskContext = new TaskContext();   
        }

        // GET: api/<TaskController>
        [HttpGet]
        public ActionResult<TaskItem[]> Get()
        {
            return _taskContext.Task.ToArray();
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public ActionResult<TaskItem?> Get(string id)
        {
            var task =  _taskContext.Task.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (task is null) return NotFound();
            return Ok(task);

        }

        // POST api/<TaskController>
        [HttpPost]
        public IActionResult Post([FromBody] TaskItem value)
        {
            try
            {
                _taskContext.Add(value);
                _taskContext.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }
    }
}
