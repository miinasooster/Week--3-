using System;

namespace PerdonalityTestSwitch
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
            string userColor = Console.ReadLine().ToLower();

            switch(userColor)
            {
                case "punane ":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline ":
                    Console.WriteLine("Oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik");
                    break;
            }

            Console.WriteLine("Kena päeva.");

        }

    }
    
}
