using Api.Entities;


namespace Services.Interfaces
{
    public interface ITaskService
    {
        List<TaskItemDTO> GetAll();
        TaskItemDTO? GetById(int id);
        int Add(SaveTaskRequest request);
        bool Update(int id, SaveTaskRequest request);
        bool Delete(int id);
    }
        
    
}
