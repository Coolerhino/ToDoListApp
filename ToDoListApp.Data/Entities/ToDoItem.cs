using System;

namespace ToDoListApp.Data.Entities
{
    public class ToDoItem
    {
        public int ToDoItemId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EstimatedFinish { get; set; }
        public bool Done { get; set; }
    }
}