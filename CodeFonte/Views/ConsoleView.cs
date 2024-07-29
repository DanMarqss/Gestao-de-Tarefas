using System;
using TaskManager.Controllers;

namespace TaskManager.Views
{
    public class ConsoleView
    {
        private readonly TaskController _taskController;

        public ConsoleView(TaskController taskController)
        {
            _taskController = taskController;
        }

        public void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Remove Task");
                Console.WriteLine("3. Update Task");
                Console.WriteLine("4. View Task");
                Console.WriteLine("5. View All Tasks");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddTask();
                        break;
                    case 2:
                        RemoveTask();
                        break;
                    case 3:
                        UpdateTask();
                        break;
                    case 4:
                        ViewTask();
                        break;
                    case 5:
                        ViewAllTasks();
                        break;
                    case 6:
                        return;
                }
            }
        }

        private void AddTask()
        {
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Due Date (yyyy-MM-dd): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Priority: ");
            int priority = int.Parse(Console.ReadLine());

            _taskController.AddTask(title, description, dueDate, priority);
        }

        private void RemoveTask()
        {
            Console.Write("Task ID: ");
            int id = int.Parse(Console.ReadLine());
            _taskController.RemoveTask(id);
        }

        private void UpdateTask()
        {
            Console.Write("Task ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Description: ");
            string description = Console.ReadLine();
            Console.Write("Due Date (yyyy-MM-dd): ");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Priority: ");
            int priority = int.Parse(Console.ReadLine());

            _taskController.UpdateTask(id, title, description, dueDate, priority);
        }

        private void ViewTask()
        {
            Console.Write("Task ID: ");
            int id = int.Parse(Console.ReadLine());
            var task = _taskController.GetTaskById(id);
            if (task != null)
            {
                Console.WriteLine($"ID: {task.Id}");
                Console.WriteLine($"Title: {task.Title}");
                Console.WriteLine($"Description: {task.Description}");
                Console.WriteLine($"Due Date: {task.DueDate}");
                Console.WriteLine($"Priority: {task.Priority}");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        private void ViewAllTasks()
        {
            var tasks = _taskController.GetAllTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Due Date: {task.DueDate}, Priority: {task.Priority}");
            }
        }
    }
}


// Esta classe representa a camada de apresentação da aplicação.
//Ela exibe um menu no console e permite que o usuário interaja com o sistema para adicionar, remover, atualizar e visualizar tarefas.
//Utiliza a TaskController para interagir com a camada de serviços.