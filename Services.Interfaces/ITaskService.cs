using Api.Entities;


namespace Services.Interfaces
{
    public interface ITaskService
    {
        List<TaskItemDTO> GetAll();
    }
    
}
