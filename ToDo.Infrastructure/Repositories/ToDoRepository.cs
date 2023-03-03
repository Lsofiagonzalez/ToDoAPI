using System;
using ToDoAPI.Core.Entitities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoAPI.Core.Interfaces;
using System.Threading.Tasks;
using ToDoAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ToDoAPI.Infrastructure.Repositories
{
   public class ToDoRepository : IToDoRepository
    {
        private readonly DbtoDoContext _context;

        public ToDoRepository(DbtoDoContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ToDo>> GetToDos()
        {
            var todo = await _context.ToDo.ToListAsync();
            return todo;
            ;
        }

        public async Task<ToDo> GetToDos(int id)
        {
            var todo = await _context.ToDo.FirstOrDefaultAsync(x=> x.Id == id);
            return todo;
            ;
        }

        public async Task InsertToDos(ToDo todo)
        {
            try
            {

                _context.ToDo.Add(todo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;

            }
        }

        public async Task<bool> UpdateToDo(ToDo todo)
        {
            try
            {
                var currentTodo = await GetToDos(todo.Id);
                currentTodo.Completado = todo.Completado;

                int rows = await _context.SaveChangesAsync();
                return rows > 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
