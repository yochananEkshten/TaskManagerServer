using Api.Entities;


namespace Repository.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskItemDTO> GetAll();
        int Add(SaveTaskRequest request);                   // ← חדש
        bool Update(int id, SaveTaskRequest request);       // ← חדש
    }
}
