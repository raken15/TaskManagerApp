using TaskManager.UI.Models;

namespace TaskManager.UI.Repositories;

public class TaskRepository : IRepository<TaskModel>
{
    private List<TaskModel> _tasks = new List<TaskModel>();

    public void Add(TaskModel entity)
    {
        _tasks.Add(entity);
    }
    public TaskModel FindById(int id)
    {
        return _tasks.FirstOrDefault(t => t.Id == id);
    }
    public IEnumerable<TaskModel> GetAll()
    {
        return _tasks;
    }

    public void Update(TaskModel entity)
    {
        if (_tasks.Any(t => t.Id == entity.Id))
        {
            _tasks[entity.Id] = entity;
        }
    }

    public void Delete(TaskModel entity)
    {
        if (_tasks.Any(t => t.Id == entity.Id))
        {
            _tasks.Remove(entity);
        }
    }
}
