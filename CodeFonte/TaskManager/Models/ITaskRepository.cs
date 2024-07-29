namespace TaskManager.Models
{
    public interface ITaskRepository
    {
        void Add(Task task);
        void Remove(int id);
        void Update(Task task);
        Task GetById(int id);
        IEnumerable<Task> GetAll();
    }
}

// Essa é a interface de Repositório, onde eu defini os métodos que um repositório de tarefas deve implementar, como adicionar, remover, atualizar e listar tarefas.