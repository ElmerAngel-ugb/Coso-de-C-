using System;
using System.Collections.Generic;

namespace TaskManager
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private int nextId = 1;

        public void AddTask(string description)
        {
            var task = new Task
            {
                Id = nextId++,
                Description = description,
                IsCompleted = false
            };
            tasks.Add(task);
        }

        public void CompleteTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.MarkAsCompleted();
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        public void ListTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }
    }
}
