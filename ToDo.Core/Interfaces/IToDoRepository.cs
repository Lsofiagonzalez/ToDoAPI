using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToDoAPI.Core.Entitities;

namespace ToDoAPI.Core.Interfaces
{
    public interface IToDoRepository
    {
        Task<IEnumerable<ToDo>> GetToDos();
        Task<ToDo> GetToDos(int id);
        Task InsertToDos(ToDo todo);

        Task<bool> UpdateToDo(ToDo todo);
    }
}
