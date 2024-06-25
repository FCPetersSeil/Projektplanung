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

        // Erstellt ein task objekt
        public Task(String x) { 
            Description = x;
            i++;
            ID = i;
        }

        // getter/setter für unser id
        public int ID { 
            get { return id; } set { id = value; }
        }

        // getter/setter für unser description
        public String Description { 
            get { return description; } set {  description = value; }
        }

        // getter/setter für unser completed
        public bool Completed { 
            get { return completed; } set {  completed = value; }
        }
    }
}
