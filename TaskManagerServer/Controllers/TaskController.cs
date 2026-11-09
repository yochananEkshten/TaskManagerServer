using Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace TaskManagerServer.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TaskController:ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public ActionResult<List<TaskItemDTO>> GetAll()
        {
            return _taskService.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<TaskItemDTO> GetById([FromRoute] int id)
        {
            TaskItemDTO? task = _taskService.GetById(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }
        [HttpPost]
        public ActionResult<int> Add([FromBody] SaveTaskRequest request)
        {
            int newId = _taskService.Add(request);
            return Ok(newId);
        }

        [HttpPut("{id}")]                                                 
        public ActionResult Update([FromRoute] int id, [FromBody] SaveTaskRequest request)
        {
            bool updated = _taskService.Update(id, request);

            if (!updated)
                return NotFound();

            return NoContent();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id)
        {
            bool deleted = _taskService.Delete(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}

