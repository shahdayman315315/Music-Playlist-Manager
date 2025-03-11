using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Playlist_Manager
{
    internal class PlayList
    {
        List<Song> l = new List<Song>();
        Dictionary<string,Song> d=new Dictionary<string, Song> ();
        //delegate void PlaySong_delegate(CancellationToken c);
        public Stack<string> st = new Stack<string> ();
        Song currentsong;
        public void AddSong(Song song)
        {
            l.Add(song); 
            d[song.title] = song; 

            Console.WriteLine("New Song was Added");
        }
        public void RemoveSong(Song song)
        {
             l.Remove(song);
            d.Remove(song.title);

            Console.WriteLine("Song has been Deleted");
        }
        public void ViewSongs()
        {
            foreach(var song in l)
            {
                Console.WriteLine(song); 
            }
        }

        public Song SearchForSong(string title)
        {
            try
            {
                Song song = d[title];
                return song;
            }
            catch 
            {
                Console.WriteLine("Song Not Found");
                return null;
            }
        }
        public async Task  PlaySongs()
        {
            foreach(Song song in l)
            {
                CancellationTokenSource cts = new CancellationTokenSource();
                currentsong = song;
                Console.WriteLine("Playing >> "+song);
                st.Push(song.title);
                await song.Play(cts);
            }
        }
        public void StopCurrentSong()
        {
            currentsong.Stop();
        }
    }
}
