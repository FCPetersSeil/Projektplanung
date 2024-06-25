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

        /// <summary>
        /// Erstellt ein TaskManager Objekt
        /// </summary>
        public TaskManager() { 
        
        }

        /// <summary>
        /// Lässt uns neue Task Objekte hinzufügen
        /// </summary>
        /// <param name="x"></param>
        public void Hinzufügen(String x) {
            for (int i = 0; i < liste.Length; i++) {
                if (Liste[i] == null) {
                    Liste[i] = new Task(x);
                    break;
                }
            }
        }

        /// <summary>
        /// Gibt das liste array aus
        /// </summary>
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

        /// <summary>
        /// lässt uns Task als erledigt makieren
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
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

        /// <summary>
        /// getter/setter für unser liste array
        /// </summary>
        public Task[] Liste { 
            get { return liste; } set { liste = value; }
        }
    }
}
