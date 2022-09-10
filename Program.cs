namespace Loopar__while__doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example();
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
    }
}