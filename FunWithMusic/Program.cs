using System;
namespace movies
{
    class Program
    {
        enum Genre
        {
            Pop,
            Indie,
            Rock,
            Rap,
            Country
        }
        struct Song
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Song(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength:" + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your favorite song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album it is from?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("P - POP\nI - INDIE\nR - ROCK\nA - RAP\nC - COUNTRY");
            Genre tempGenre = Genre.Pop;
            char g = char.Parse(Console.ReadLine());
            switch (g)
            {
                case 'P':
                    tempGenre = Genre.Pop;
                    break;
                case 'I':
                    tempGenre = Genre.Indie;
                    break;
                case 'R':
                    tempGenre = Genre.Rock;
                    break;
                case 'A':
                    tempGenre = Genre.Rap;
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
            }
            Song song = new Song(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Song newSong = song;
            //changing values in the new structure variable
            newSong.setTitle("Pocket Party");
            newSong.setArtist("Polly Pocket");
            newSong.setAlbum("Polly Pocket and Friends");
            newSong.setLength("2 minutes");
            //Printing the new movie
            Console.WriteLine("Here's song #2");
            Console.WriteLine($"{newSong.Display()}");
            Console.WriteLine();
            //Printing the original
            Console.WriteLine("Here's song #1");
            Console.WriteLine($"{song.Display()}");
        }
    }
}