namespace TheReplicator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Console.WriteLine("Please type in 5 numbers.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            int.TryParse(Console.ReadLine(), out numbers[0]);
            int.TryParse(Console.ReadLine(), out numbers[1]);
            int.TryParse(Console.ReadLine(), out numbers[2]);
            int.TryParse(Console.ReadLine(), out numbers[3]);
            int.TryParse(Console.ReadLine(), out numbers[4]);

            Console.ForegroundColor = ConsoleColor.Gray; 
            
            int[] copiedNumbers = new int[5];
            Console.WriteLine("Copying your numbers.");

            for(int i = 0; i < numbers.Length; i++)
            {
                copiedNumbers[i] = numbers[i];
            }

            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"YourNumber: {numbers[i]}, CopiedNumber: {copiedNumbers[i]}");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Thanks!");            

        }
    }
}