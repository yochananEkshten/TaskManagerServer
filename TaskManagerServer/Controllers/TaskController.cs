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
    }
}

