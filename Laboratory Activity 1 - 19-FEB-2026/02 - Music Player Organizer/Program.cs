using System;

namespace MusicPlaylistOrganizer
{
    class Song
    {
        public string title;
        public string artist;
        public double duration;

        public Song()
        {
            title = "Unknown";
            artist = "Unknown";
            duration = 0.0;
        }

        public Song(string songTitle, string songArtist)
        {
            title = songTitle;
            artist = songArtist;
            duration = 0.0;
        }

        public Song(string songTitle, string songArtist, double songDuration)
        {
            title = songTitle;
            artist = songArtist;
            duration = songDuration;
        }

        public void DisplaySong()
        {
            Console.WriteLine("{0,-15} {1,-15} {2,5:F2}", title, artist, duration);
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Songs to add: ");
            int size = int.Parse(Console.ReadLine()!);

            Song[] myPlaylist = new Song[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\nSong #" + (i + 1));

                Console.Write("Title: ");
                string t = Console.ReadLine();

                Console.Write("Artist: ");
                string a = Console.ReadLine();

                Console.Write("Duration (minutes): ");
                double d = double.Parse(Console.ReadLine());

                myPlaylist[i] = new Song(t, a, d);
            }

            Console.WriteLine("\n=== || MY PLAYLIST || ===");
            Console.WriteLine("{0,-15} {1,-15} {2,5}", "Title", "Artist", "Time");
            Console.WriteLine("--------------------------------------------");

            double totalTime = 0;

            for (int i = 0; i < size; i++)
            {
                myPlaylist[i].DisplaySong();
                totalTime = totalTime + myPlaylist[i].duration;
            }

            double average = totalTime / size;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Total Duration: " + totalTime.ToString("F2") + " mins");
            Console.WriteLine("Average Duration: " + average.ToString("F2") + " mins");
        }
    }
}