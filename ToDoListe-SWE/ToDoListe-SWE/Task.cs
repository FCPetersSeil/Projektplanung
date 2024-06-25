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

        /// <summary>
        /// Erstellt ein task objekt
        /// </summary>
        /// <param name="x"></param>
        public Task(String x) { 
            Description = x;
            i++;
            ID = i;
        }

        /// <summary>
        /// getter/setter für unser id
        /// </summary>
        public int ID { 
            get { return id; } set { id = value; }
        }


        /// <summary>
        /// getter/setter für unser description
        /// </summary>
        public String Description { 
            get { return description; } set {  description = value; }
        }

        /// <summary>
        /// getter/setter für unser completed
        /// </summary>
        public bool Completed { 
            get { return completed; } set {  completed = value; }
        }
    }
}
