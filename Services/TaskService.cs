using Api.Entities;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public List<TaskItemDTO> GetAll()
        {
            return _taskRepository.GetAll();
        }
        public TaskItemDTO? GetById(int id)
        {
            return _taskRepository.GetById(id);
        }
        public int Add(SaveTaskRequest request)                      
        {
            return _taskRepository.Add(request);
        }

        public bool Update(int id, SaveTaskRequest request)           
        {
            return _taskRepository.Update(id, request);
        }
        public bool Delete(int id)
        {
            return _taskRepository.Delete(id);
        }
      
    }
}
