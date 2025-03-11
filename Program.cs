namespace Music_Playlist_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayList p1= new PlayList();
            Song song1= new Song();
            song1.title = "Song 1";
            song1.artist = "Artist 1";
            song1.duration = 4000;
            song1.AdditionDate = DateTime.Now;
            p1.AddSong(song1 );
            Song song2 = new Song();
            song2.title = "Song 2";
            song2.artist = "Artist 2";
            song2.duration = 5000;
            song2.AdditionDate = DateTime.Now;
            p1.AddSong(song2);
            Song song3 = new Song();
            song3.title = "Song 3";
            song3.artist = "Artist 3";
            song3.duration = 3000;
            song3.AdditionDate = DateTime.Now;
            p1.AddSong(song3);
            p1.PlaySongs();
            Thread.Sleep(5000);
            p1.StopCurrentSong();
            Console.ReadKey();
        }
    }

}
