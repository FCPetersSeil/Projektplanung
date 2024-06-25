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

        // Erstellt ein TaskManager Objekt
        public TaskManager() { 
        
        }

        // Lässt uns neue Task Objekte hinzufügen
        public void Hinzufügen(String x) {
            for (int i = 0; i < liste.Length; i++) {
                if (Liste[i] == null) {
                    Liste[i] = new Task(x);
                    break;
                }
            }
        }

        // Gibt das liste array aus
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

        // lässt uns Task als erledigt makieren
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

        // getter/setter für unser liste array
        public Task[] Liste { 
            get { return liste; } set { liste = value; }
        }
    }
}
