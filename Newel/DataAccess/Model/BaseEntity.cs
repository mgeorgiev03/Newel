using System.ComponentModel.DataAnnotations;

namespace DataAccess.Model
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
