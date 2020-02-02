using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DrawingEntry> list = FileActions.CreateListOfNames();

            #region For debug only, preview list
            //foreach (var record in list)
            //{
            //    Console.WriteLine($"{record.Name}\t\t{record.Amount}\t\t{record.TotalTickets}");
            //}
            #endregion

            List<string> listExpanded = new List<string>();

            foreach (var record in list)
            {
                for (int i = 0; i < record.TotalTickets; i++)
                {
                    listExpanded.Add(record.Name);
                }
            }

            #region For debug only, preview list
            //foreach (var x in listExpanded)
            //{
            //    Console.WriteLine(x);
            //}
            #endregion

            Drawing.PerformRandomDrawing(listExpanded);

            Console.Read();
        }
    }
}
