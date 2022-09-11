namespace Loopar__while__doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parenteserna efter while ska innehålla ett booleskt uttryckt precis som en if-sats.
            //Allt som du skulle kunna skriva i en if-sats kan du också skriva i en while-loop.
            
            FemtioBaklänges();
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
        
        }
    
    }
}
