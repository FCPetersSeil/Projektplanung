using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListe_SWE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager manager = new TaskManager();
            manager.Hinzufügen("Java Lernen");
            manager.Hinzufügen("Write Code");
            manager.Anzeigen();

            manager.Markieren(1);
            manager.Anzeigen();
        }
    }
}
