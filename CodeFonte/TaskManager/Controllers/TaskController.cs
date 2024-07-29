using System.Collections.Generic;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    public class TaskController
    {
        private readonly TaskService _taskService;

        public TaskController(TaskService taskService)
        {
            _taskService = taskService;
        }

        public void AddTask(string title, string description, DateTime dueDate, int priority)
        {
            _taskService.AddTask(title, description, dueDate, priority);
        }

        public void RemoveTask(int id)
        {
            _taskService.RemoveTask(id);
        }

        public void UpdateTask(int id, string title, string description, DateTime dueDate, int priority)
        {
            _taskService.UpdateTask(id, title, description, dueDate, priority);
        }

        public TaskManager.Models.Task GetTaskById(int id)
        {
            return _taskService.GetTaskById(id);
        }

        public IEnumerable<TaskManager.Models.Task> GetAllTasks()
        {
            return _taskService.GetAllTasks();
        }
    }
}



//Essa classe, creio que é uma das mais importantes, ela faz a ligação entre a apresentação e a camada de serviço, basicamente expôe os metódos do CRUD, delegando a lógica de negócios para a TaskService.
