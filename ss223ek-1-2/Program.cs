using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ss223ek_1_2
{
    class Program
    {
        //Rita med asterisker
        static void Main(string[] args)
        {
            // rad 1-25
            // varannan rad ska skjutas in "ett tomrum"  hitta detta med mudulo2 i if-villkor (skriv ev ut " ")
            // var tredje rad ska vara gul, hitta detta med modul3 i en switch-sats

            int rowNumber, colNumber;

            for (rowNumber = 1; rowNumber < 26; rowNumber++)
            {
                if (0 == rowNumber % 2)             //om det är jämn rad, skriv inlednade mellanslag
                {
                    Console.Write(" ");
                }

                switch(rowNumber%3)                 // var tredje
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                                
                }

                // för varje rad ska det finns kolumn 1-39
                // (skriv ut " *")

                for (colNumber = 1; colNumber < 40; colNumber++)
                {
                    Console.Write("* ");

                }
                // (skriv ut radbrytning) innan återhopp i yttre loop
                Console.WriteLine();

            
            
            
            }

            




        }
    }
}
