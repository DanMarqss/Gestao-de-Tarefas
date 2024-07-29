namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; }
    }
}

// Essa é a Modelagem de Dados onde foi solicitado no teste para que criasse os seguintes atributos: itle, Description, DueDate, Priority
