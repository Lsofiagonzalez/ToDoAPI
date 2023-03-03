using System;
using System.Collections.Generic;

namespace ToDoAPI.Core.Entitities
{

    public partial class ToDo
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public DateTime FechaCreacion { get; set; }

        public bool Completado { get; set; }
    }
}