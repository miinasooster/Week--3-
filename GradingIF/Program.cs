using System;

namespace GradingIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib, mis hinde kasutaja sai;
            //Kui kasutaja sai 'A', siis kuvab konsool ''Suurepärane!'';
            //Kui kasutaja sai 'B', siis kuvab konsool ''Väga hea!'';
            //Kui kasutaja sai 'C', siis kuvab konsool ''Hea!'';
            //Kui kasutaja sai 'D', siis kuvab konsool ''Rahuldav!'';
            //Kui kasutaja sai 'E', siis kuvab konsool ''Kasin!'';
            //Kui kasutaja sai 'F', siis kuvab konsool ''Puudulik!'';
            //Kui kasutaja sisetab midagi muud, kuvab konsool ''Vale väärtus'';

            //kasutan IF
 

            Console.WriteLine("Palun, sisesta oma tulemus:");
            //char -  character
            char userResult = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userResult =='A') 

            {
                Console.WriteLine("Suurepärane!");
            }

            else if (userResult == 'B')
            {
                Console.WriteLine("Väga hea!");
            }

            else if (userResult == 'C')
            {
                Console.WriteLine("Hea!");
            }

            else if (userResult == 'D')
            {
                Console.WriteLine("Rahuldav!");
            }

            else if (userResult == 'E')
            {
                Console.WriteLine("Kasin!");
            }

            else if (userResult == 'F')
            {
                Console.WriteLine("Vale väärtus");
            }

            else

            {
                Console.WriteLine("Vale väärtus!");
            }


            Console.WriteLine("Kena päeva!");

        }
    }
}
