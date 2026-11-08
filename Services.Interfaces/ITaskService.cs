using Api.Entities;


namespace Services.Interfaces
{
    public interface ITaskService
    {
        List<TaskItemDTO> GetAll();
        int Add(SaveTaskRequest request);                   
        bool Update(int id, SaveTaskRequest request);
    }
    
}
