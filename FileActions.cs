using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestDrawing
{
    public static class FileActions
    {
        public static List<DrawingEntry> CreateListOfNames()
        {
            string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Donations.csv");
            List<DrawingEntry> drawingList = new List<DrawingEntry>();
            
            using (var reader = new StreamReader(file))
            {
                while (!reader.EndOfStream)
                {
                    DrawingEntry entry = new DrawingEntry();

                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    entry.Name = values[0];
                    entry.Amount = Convert.ToInt32(values[1]);
                    double thisAmount = (double)(entry.Amount);
                    entry.TotalTickets = Convert.ToInt32(Math.Floor(thisAmount/10));

                    drawingList.Add(entry);
                }
            }

            return drawingList;
        }
    }
}
