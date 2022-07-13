namespace ToDoList.Models
{
    public class Item
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; } = false;
    }
}
