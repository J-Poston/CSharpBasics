namespace PracticeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Tommy","Stu","Angelica"};

            names.Add("John");
            names.Add("Mark");
            names.Add("Vladica");
            names.Add("Stacey");
            names.Add("Collette");
            names.Add("Jeremiah");
            names.Insert(5, "Tony");

            if (names.Contains("Jason"))
            {

            }

            foreach (string name in names)
            {
                Console.WriteLine($"{name}, {names.IndexOf(name)}");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
                names.Remove(names[i]);
            }

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}