namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);  

            int maxAttempts = 5;

            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                Console.Write("Gissning " + attempt + ": ");
                string input = Console.ReadLine();

               
                if (!int.TryParse(input, out int userGuess))
                {
                    Console.WriteLine("Ogiltig inmatning! Skriv ett heltal.");
                    attempt--; 
                    continue;
                }

               
                if (CheckGuess(userGuess, number))
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    return; 
                }
                else if (userGuess < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                }
                else 
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                }
            }

            Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
        }

      
        static bool CheckGuess(int guess, int correctNumber)
        {
            return guess == correctNumber;
        }
                
                } 
            }
    

