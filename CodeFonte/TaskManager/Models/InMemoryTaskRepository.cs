using System.Collections.Generic;
using System.Linq;

namespace TaskManager.Models
{
    public class InMemoryTaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();
        private int _currentId = 1;

        public void Add(Task task)
        {
            task.Id = _currentId++;
            _tasks.Add(task);
        }

        public void Remove(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }

        public void Update(Task task)
        {
            var existingTask = _tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.DueDate = task.DueDate;
                existingTask.Priority = task.Priority;
            }
        }

        public Task GetById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Task> GetAll()
        {
            return _tasks;
        }
    }
}


// Aqui eu verifiquei em algumas video aulas e conforme pedido no desafio também para utilizar uma estrutura de dados, utilizei uma lista para armazenar as tarefas
//E gerencia um id único para ccada nova tarefa.