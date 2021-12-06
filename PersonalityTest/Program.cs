using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutajal sisestada tema lemmikvärv;
            //Kui kasutaja sisestab ''punane'', siis konsool kuvab ''Oled romantiline'';
            //Kui kasutaja sisestab ''sinine'', siis konsool kuvab ''Oled töökas'';
            //Kui kasutaja sisestab ''roheline'', siis koonsool kuvab ''Oled looduse sõber'';
            //Kui kasutaja sisestab midagi muud, siis konsool kuvab ''Oled {userColor} ükssarvik''

            Console.WriteLine("Sisesta oma lemmikvärv: ");
            char userChoice = Convert.ToChar(Console.ReadLine().ToUpper());

            if (userChoice == "CAT")
            {
                Console.WriteLine("Oled romantiline.");
            }

            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }

            else if (userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }

            else 

            {
                Console.WriteLine($"Oled {userColor} ükssarvik. ");
            }


            Console.WriteLine("Kena päeva! :) ");
        }
    }

}