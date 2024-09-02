using System;

namespace TaskManager
{
    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public void MarkAsCompleted()
        {
            IsCompleted = true;
        }

        public override string ToString()
        {
            return $"{Id}: {Description} - {(IsCompleted ? "Completed" : "Pending")}";
        }
    }
}
