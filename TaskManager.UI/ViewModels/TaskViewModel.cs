using TaskManager.UI.Models;
using TaskManager.UI.Repositories;
using System.Collections.ObjectModel;
using System.Windows.Input;
using TaskManager.UI.Commands;

namespace TaskManagerApp.ViewModels
{
    public class TaskViewModel
    {
        private readonly TaskRepository _taskRepository;
        public ObservableCollection<TaskModel> TasksCollection { get; set; }
        public ICommand AddTaskCommand;

        public TaskViewModel()
        {
            _taskRepository = new TaskRepository();
            TasksCollection = new ObservableCollection<TaskModel>(_taskRepository.GetAll());

            //AddTaskCommand = new RelayCommand(AddTask);
        }
        private void AddTask()
        {
            TaskModel newTask = new TaskModel { Id = TasksCollection.Count + 1, Name = "New Task", Description = "New Task Description", IsCompleted = false };
            _taskRepository.Add(newTask);
            TasksCollection.Add(newTask);
        }
    }
}