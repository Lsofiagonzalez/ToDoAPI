using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoAPI.Core.Entitities
{
   public class ToDo
    {
        public int id { get; set; }
        public string titulo { get; set; }

        public DateTime fecha { get; set; }

        public bool completado { get; set; }
    }

}
