using Api.Entities;


namespace Repository.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskItemDTO>GetAll();
    }
}
