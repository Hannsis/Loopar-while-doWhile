namespace Loopar__while__doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parenteserna efter while ska innehålla ett booleskt uttryckt precis som en if-sats.
            //Allt som du skulle kunna skriva i en if-sats kan du också skriva i en while-loop.
            
            MenyProgramMiniräknare();
        }


        static void Example()
        {
            Console.WriteLine("Skriv in ett ord");
            Console.WriteLine("Skriv ordet 'Klar' för att avsluta");

            string användarensOrd = Console.ReadLine();

            while (användarensOrd != "Klar")
            {
                Console.WriteLine($"Du skrev in ordet {användarensOrd}");
                Console.WriteLine("Skriv in ett ord till");
                Console.WriteLine("Skriv ordet 'Klar' för att avsluta");
                användarensOrd = Console.ReadLine();
            }

            Console.WriteLine("Du skrev ordet 'Klar', programmet kommer att avslutas");

        }

        static void Land()
        {
            Console.WriteLine("Vilket är världens folkrikaste land?:");
            string svar = Console.ReadLine();

            while (svar != "Kina")
            {
                Console.WriteLine("Fel svar, försök igen");
                svar = Console.ReadLine();
            }
            Console.WriteLine("Rätt svar");
        }

        static void TillFemtio()
        {//i fungerar som en räknare som anger vilken körning som loopen är inne på.
            int i = 0;
            while (i <= 50)
            {
                Console.WriteLine(i);
                i++; 
            }
        }

        static void FemtioBaklänges() 
        {
            int i = 50;

            while( i > 0)
            {
                Console.WriteLine(i);
                i--;
            }
        }

        static void MenyProgram() 
        {
            Console.WriteLine("Välj ett av följande alternativ.");
            Console.WriteLine("1. Addera två tal");
            Console.WriteLine("2. Multiplicera två tal");

            string användarensVal = Console.ReadLine();

            // Utför det val som användaren ville göra

            switch (användarensVal) //EJ LOOP
            {
                case "1":
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double tal1 = double.Parse(Console.ReadLine());
                    double tal2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{tal1}+{tal2}={tal1 + tal2}");
                    break;

                case "2":
                    Console.WriteLine("Skriv in två tal på var sin rad");
                    double faktor1 = double.Parse(Console.ReadLine());
                    double faktor2 = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{faktor1}*{faktor2}={faktor1 * faktor2}");
                    break;

                default:
                    Console.WriteLine("Du valde inte ett giltigt alternativ.");
                    break;
            }

        }

        static void MenyProgramMiniräknare() 
        {
            Console.WriteLine("Detta är ett program som omvandlar KM till M och tvärtom. ");
            string användarensVal = "";

            while (användarensVal != "3")
            {
                Console.WriteLine("Välj vad du vill räkna på: ");
                Console.WriteLine("1. KM till M");
                Console.WriteLine("2. M till KM");
                Console.WriteLine("3. Avsluta");

                användarensVal = Console.ReadLine();
                
                switch (användarensVal)
                {
                    case "1":
                        Console.WriteLine("tjolaho, KM till Meter.");
                        Console.WriteLine("Skriv in km:");
                        double kM = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{kM} * 1000");
                        break;

                    case "2":
                        Console.WriteLine("tjolahej. meter till km.");                      
                        Console.WriteLine("Skriv in km:");                        
                        double m = double.Parse(Console.ReadLine());
                        Console.WriteLine($"{m} / 1000");
                        break;
                        break;

                    case "3":
                        Console.WriteLine("potatis");
                        break;
                  
                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ.");
                        break;

                }
            }

        }
          
    }

    
}

    
    

