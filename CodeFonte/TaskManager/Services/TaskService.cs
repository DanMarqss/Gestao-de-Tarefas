using TaskManager.Models;

namespace TaskManager.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void AddTask(string title, string description, DateTime dueDate, int priority)
        {
            var task = new Task
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                Priority = priority
            };
            _taskRepository.Add(task);
        }

        public void RemoveTask(int id)
        {
            _taskRepository.Remove(id);
        }

        public void UpdateTask(int id, string title, string description, DateTime dueDate, int priority)
        {
            var task = new Task
            {
                Id = id,
                Title = title,
                Description = description,
                DueDate = dueDate,
                Priority = priority
            };
            _taskRepository.Update(task);
        }

        public Task GetTaskById(int id)
        {
            return _taskRepository.GetById(id);
        }

        public IEnumerable<Task> GetAllTasks()
        {
            return _taskRepository.GetAll();
        }
    }
}


//Aqui é a classe que tem a lógica de negócios para gerenciar tarefas. Ela utiliza a interface de repositório para realizar as operações CRUD.