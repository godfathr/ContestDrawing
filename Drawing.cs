using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContestDrawing
{
    public static class Drawing
    {
        public static int numberOfEntries;
        public static string winner;
        
        public static string PerformRandomDrawing(List<string> entryList)
        {
            Console.WriteLine($"Total Tickets: {entryList.Count}");

            //do the actual random drawing
            numberOfEntries = entryList.Count;

            Random rnd = new Random();

            var winningTicket = rnd.Next(0, numberOfEntries);

            Console.WriteLine($"Winning Ticket Number: {winningTicket}");

            winner = entryList.Skip(winningTicket - 1).Take(1).SingleOrDefault();

            Console.WriteLine($"Winning Name: {winner}");

            return winner;
        }
    }
}
