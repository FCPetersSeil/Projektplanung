using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListe_SWE
{
    internal class Task
    {
        static int i = 0;
        int id;
        String description;
        bool completed = false;

        public Task(String x) { 
            Description = x;
            i++;
            ID = i;
        }

        public int ID { 
            get { return id; } set { id = value; }
        }

        public String Description { 
            get { return description; } set {  description = value; }
        }

        public bool Completed { 
            get { return completed; } set {  completed = value; }
        }
    }
}
