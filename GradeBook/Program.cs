namespace GradeBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your student's name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter student's 10 test scores.");

            double[] testScores = new double[10];

            for(int i = 0; i < testScores.Length; i++)
            {
                double.TryParse(Console.ReadLine(), out testScores[i]);
            }

            double totalScore = 0;

            foreach(double testScore in testScores)
            {
                totalScore += testScore;
            }

            double avgScore = totalScore / testScores.Length;

            Console.WriteLine($"Average Score: {avgScore}");
            
            if(avgScore > 60) {
                Console.WriteLine($"{studentName} passed.");                
            }
            else {
                Console.WriteLine($"{studentName} failed.");
            }

        }
    }
}