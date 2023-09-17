using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public class ToDoList : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        public List<ToDoItem> Tasks { get; set; }
    }
}
