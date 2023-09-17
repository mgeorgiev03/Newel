using DataAccess.Model;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ToDoItemRepository : BaseRepository<ToDoItem>, IToDoItemRepository
    {
        public ToDoItemRepository(DbContext _context) : base(_context)
        {
        }
    }
}
