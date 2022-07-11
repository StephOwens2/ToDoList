namespace ToDoList.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; } = false;
    }
}
