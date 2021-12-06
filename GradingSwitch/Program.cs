using System;

namespace GradingSwitch
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


            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin!");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik!");
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }

            Console.WriteLine("Kena päeva.");



        }
    }
}
