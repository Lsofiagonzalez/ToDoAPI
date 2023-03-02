using System;
using ToDoAPI.Core.Entitities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoAPI.Core.Interfaces;
using System.Threading.Tasks;

namespace ToDoAPI.Infrastructure.Repositories
{
   public class ToDoRepository : IToDoRepository
    {
        public async Task<IEnumerable<ToDo>> GetToDos()
        {
            var todo = Enumerable.Range(1, 10).Select(x => new ToDo
            {
                id = x,
                titulo = $"titulo{x}",
                fecha = DateTime.Now,
                completado = true

            });
            await Task.Delay(10);
            return todo;
            ;
        }
    }
}
