using System;

namespace Meny
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitProgram = false;
            while (!exitProgram)
            {
                Console.WriteLine();
                Console.WriteLine(" ------Huvudmeny------");
                Console.WriteLine(" Avsluta programmet: 0");
                Console.WriteLine("               Pris: 1");
                Console.WriteLine("           Gruppris: 2");
                Console.WriteLine("    Dela upp mening: 3");
                Console.Write("\n Välj en siffra ovan: ");
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "0":
                        {
                            exitProgram = true;
                            break;
                        }
                    case "1":
                        {
                            Price();
                            break;
                        }
                    case "2":
                        {
                            PriceForGroup();
                            break;
                        }
                    case "3":
                        {
                            SplitSentence();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Felaktigt val!");
                            break;
                        }
                }
            }
        }

        private static void SplitSentence()
        {
            Console.Write("Skriv in en mening med minst 3 ord: ");
            string sentence = Console.ReadLine();
            var words = sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);          
            Console.WriteLine($"Det tredje ordet i meningen är \"{words[2]}\".");                             
        }

        private static void PriceForGroup()
        {
            Console.WriteLine("Ange hur många ni är i gruppen: ");
            int nrOfPersons = int.Parse(Console.ReadLine());

            int totalCost = 0;
            for(int personIndex = 1; personIndex <= nrOfPersons; personIndex++)
            {
                Console.WriteLine($"Skriv in din ålder för person {personIndex}: ");
                int age = int.Parse(Console.ReadLine());
                if (age <= 19)
                {
                    totalCost = totalCost + 80;
                }
                else if (age >= 65)
                {
                    totalCost = totalCost + 90;
                }
                else
                {
                    totalCost = totalCost + 120;
                }
            }
            Console.WriteLine($"Ni är {nrOfPersons} í gruppen.");
            Console.WriteLine($"Totalkostnaden för gruppen är {totalCost}.");
        }

        private static void Price()
        {
            Console.WriteLine("Skriv in din ålder: ");
            int age = int.Parse(Console.ReadLine());
            if (age <= 19)
            {
                Console.WriteLine("Ungdomspris: 80kr");
            }
            else if (age >= 65)
            {
                Console.WriteLine("Pensionärspris: 90kr");
            }
            else
            {
                Console.WriteLine("Standardpris: 120kr");
            }

        }
    }
}
