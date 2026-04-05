using System;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            SayaTubeUser user = new SayaTubeUser("Irsyad Sasmoyo Pramudito");

            string[] films = {
                "Interstellar",
                "Inception",
                "The Dark Knight",
                "Tenet",
                "Avengers: Endgame",
                "Parasite",
                "The Joker",
                "Oppenheimer",
                "Whiplash",
                "The Matrix"
            };

            SayaTubeVideo[] videos = new SayaTubeVideo[films.Length];

            for (int i = 0; i < films.Length; i++)
            {
                videos[i] = new SayaTubeVideo($"Review Film {films[i]} oleh Irsyad Sasmoyo Pramudito");

                for (int j = 0; j < 5; j++)
                {
                    videos[i].IncreasePlayCount(1000000);
                }

                user.AddVideo(videos[i]);
            }

            user.PrintAllVideoPlaycount();

            Console.WriteLine("\nDetail Salah Satu Video:");
            videos[0].PrintVideoDetails();

            Console.WriteLine($"\nTotal Play Count: {user.GetTotalVideoPlayCount()}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"ERROR: {e.Message}");
        }
    }
}