using Api.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class TaskRepository:ITaskRepository
    {
        private readonly IDbContextFactory<TaskManagerContext> _factory;
        private readonly IMapper _mapper;
        public TaskRepository(IDbContextFactory<TaskManagerContext> factory, IMapper mapper)
        {
            _factory = factory;
            _mapper = mapper;
        }
        public List<TaskItemDTO> GetAll()
        {
            using (TaskManagerContext context = _factory.CreateDbContext())
            {
                List<TaskItem> tasks = context.TaskItems
                    .OrderByDescending(t => t.TaskLevel)
                    .ThenBy(t => t.CreatedAt)
                    .ToList();

                return _mapper.Map<List<TaskItemDTO>>(tasks);
            }
        }
        public int Add(SaveTaskRequest request)                                 // ← חדש
        {
            using (TaskManagerContext context = _factory.CreateDbContext())
            {
                TaskItem task = _mapper.Map<TaskItem>(request);
                task.CreatedAt = DateTime.UtcNow;

                context.TaskItems.Add(task);
                context.SaveChanges();

                return task.Id;
            }
        }

        public bool Update(int id, SaveTaskRequest request)                     // ← חדש
        {
            using (TaskManagerContext context = _factory.CreateDbContext())
            {
                TaskItem? task = context.TaskItems.Find(id);
                if (task == null)
                    return false;

                _mapper.Map(request, task);
                context.SaveChanges();
                return true;
            }
        }
    }
}
