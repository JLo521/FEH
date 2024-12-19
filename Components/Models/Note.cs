using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEH.Components.Models
{
    public class Note
    {
        public string Message { get; }

        public DateTimeOffset Created { get; }

        public Note(string message)
        {
            Message = message;
            Created = DateTimeOffset.UtcNow;
        }
    }
}
