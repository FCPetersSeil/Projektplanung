using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListe_SWE
{
    internal class TaskManager
    {
        Task[] liste = new Task[10]; 

        public TaskManager() { 
        
        }

        public void Hinzufügen(String x) {
            for (int i = 0; i < liste.Length; i++) {
                if (Liste[i] == null) {
                    Liste[i] = new Task(x);
                    break;
                }
            }
        }

        public void Anzeigen() { 
            Console.Clear();
            for (int i = 0;i < liste.Length; i++) {
                if (Liste[i] == null) {
                    break;
                }else {
                    Console.WriteLine(Liste[i].Description + " | Ist Erledigt: " + Liste[i].Completed);
                }
            }
        }

        public Task Markieren(int x) { 
            for (int i = 0; i < Liste.Length ; i++ ) {
                if (x.Equals(Liste[i].ID))
                {
                    Liste[i].Completed = true;
                    return Liste[i];
                }
            }
            return null;
        }

        public Task[] Liste { 
            get { return liste; } set { liste = value; }
        }
    }
}
