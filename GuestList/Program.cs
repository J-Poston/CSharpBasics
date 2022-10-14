namespace GuestList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>() { "Shan","John","Scott","Cass","Katie" };

            PrintGuestList(guests);

            Console.WriteLine("We need 5 more peeps. Who you want?");

            for(int i = 0; i < 5; i++)
            {
                guests.Add(Console.ReadLine().ToLower());
            }

            PrintGuestList(guests);

            Console.WriteLine("Oops, we have too many guets. Please uninvite 2 people by name.");

            for (int i = 0; i < 2; i++)
            {
                int lastIndexOfRemove = guests.LastIndexOf(Console.ReadLine());
                guests.RemoveAt(lastIndexOfRemove);
            }

            PrintGuestList(guests);

        }
        static void PrintGuestList(List<string> guests)
        {
            Console.WriteLine("Guest list:");
            foreach (string guest in guests)
            {
                Console.WriteLine($"{guest}");
            }
        }
    }
}