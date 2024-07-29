using TaskManager.Controllers;
using TaskManager.Models;
using TaskManager.Services;
using TaskManager.Views;

class Program
{
    static void Main(string[] args)
    {
        ITaskRepository taskRepository = new InMemoryTaskRepository();
        TaskService taskService = new TaskService(taskRepository);
        TaskController taskController = new TaskController(taskService);
        ConsoleView consoleView = new ConsoleView(taskController);

        consoleView.DisplayMenu();
    }
}


//Esse é ponto de entrada dessa aplicação toda, vai configurar as dependências e inicia a interface do console. 
//Quando executado o método "main" é chamado e a interface do console é exibida.