using Api.Entities;


namespace Repository.Interfaces
{
    public interface ITaskRepository
    {
        List<TaskItemDTO> GetAll();
        TaskItemDTO GetById(int id);
        int Add(SaveTaskRequest request);               
        bool Update(int id, SaveTaskRequest request);
        bool Delete(int id);
       
}
}
   
