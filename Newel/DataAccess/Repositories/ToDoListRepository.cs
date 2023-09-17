using DataAccess.Model;
using DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public class ToDoListRepository : BaseRepository<ToDoList>, IToDoListRepository
    {
        public ToDoListRepository(DbContext _context) : base(_context)
        {
        }
    }
}
