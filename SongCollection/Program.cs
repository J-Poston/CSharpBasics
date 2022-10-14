namespace SongCollection
{
    internal class Program
    {

        static List<string> genres = new List<string>() { "Pop", "Jazz", "Rock", "Country", "Alternative" };

        static Dictionary<string, string> songs = new Dictionary<string, string>();
        static void Main(string[] args)
        {

            string song; 
            string genre;
            bool repeat = true;

            while (repeat == true)
            {
                song = GetSongName();
                genre = GetGenreName();

                songs.TryAdd(song, genre);

                repeat = AskToRepeat();
            }

            PrintSongCollection();

        }

        static string GetSongName()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Enter song name:");
            Console.ForegroundColor = ConsoleColor.Gray;
            string song = Console.ReadLine();
            return song;
        }

        static string GetGenreName()
        {
            bool validGenre = false;
            string genre = "";

            while (validGenre == false)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter genre:");
                Console.ForegroundColor = ConsoleColor.Gray;
                genre = Console.ReadLine();
                validGenre = IsValidGenre(genre); 
                if (validGenre == false)
                {
                    Console.WriteLine("Invalid genre. Choose from list below.");
                    Console.WriteLine("--------------------------------------");
                    PrintGenres();
                }                
            }

            return genre;
        }

        static bool IsValidGenre(string genre)
        {
            bool validGenre = false;

            if (genres.Contains(genre)) { validGenre = true; }

            return validGenre;
        }

        static void PrintGenres()
        {
            foreach(string genre in genres)
            {
                Console.WriteLine(genre);
            }
        }

        static void PrintSongCollection()
        {
            Console.WriteLine("Song Collection:");

            foreach (KeyValuePair<string,string> song in songs)
            {
                Console.WriteLine($"{song.Key},{song.Value}");
            }
        }

        static bool AskToRepeat()
        {
            bool repeat = false;
            bool validBool = false;

            while (validBool == false)
            {
                Console.WriteLine("Repeat? Enter true or false");
                validBool = bool.TryParse(Console.ReadLine(), out repeat);
            }
            return repeat;
        }
    }
}