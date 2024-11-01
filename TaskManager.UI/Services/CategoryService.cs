using TaskManager.UI.Repository;
using TaskManager.UI.Models;

namespace TaskManager.UI.Services;

public class CategoryService : IRepository<Category>
{
    private List<Category> _categories = new List<Category>();

    public void Add(Category entity)
    {
        _categories.Add(entity);
    }
    public Category FindById(int id)
    {
        return _categories.FirstOrDefault(c => c.Id == id);
    }
    public IEnumerable<Category> GetAll()
    {
        return _categories;
    }   

    public void Update(Category entity)
    {
        if(_categories.Any(c => c.Id == entity.Id))
        {
            _categories[entity.Id] = entity;
        }
    }

    public void Delete(Category entity)
    {
        if (_categories.Any(c => c.Id == entity.Id))
        {
            _categories.Remove(entity);
        }
    }
}
