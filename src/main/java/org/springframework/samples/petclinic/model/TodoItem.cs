using System;

namespace spring-petclinic.Models // Replace 'YourNamespace' with the actual namespace
{
    public class TodoItem
    {
        public int Id { get; set; } // Unique identifier for the todo item
        public string Title { get; set; } // Title of the todo item
        public string Description { get; set; } // Description of the todo item
        public bool IsCompleted { get; set; } // Status of the todo item
        public DateTime CreatedAt { get; set; } // Creation date of the todo item
        public DateTime? DueDate { get; set; } // Optional due date for the todo item

        // You may also want to add a constructor
        public TodoItem()
        {
            CreatedAt = DateTime.Now; // Set created date to now by default
        }
    }
}
