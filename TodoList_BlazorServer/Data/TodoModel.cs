using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList_BlazorServer.Data
{
    public class TodoModel
    {
        public int Id { get; set; }

        public string Todo { get; set; }

        public DateTime Deadline { get; set; }

        public bool IsCompleted { get; set; }

    }
}
