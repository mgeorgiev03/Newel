﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class ToDoItem : BaseEntity
    {
        [Required]
        public string Text { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime dateTime { get; set; }

        public virtual List<ToDoItem> Subtasks { get; set; }
    }
}
