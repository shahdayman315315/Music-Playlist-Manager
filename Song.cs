using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Playlist_Manager
{
    internal class Song
    {
        public string title {  get; set; }
        public string artist { get; set; }
        public int duration {  get; set; }
        public DateTime AdditionDate { get; set; }
        public int TimesPlayed = 0;
        CancellationTokenSource cts;

        public async Task Play(CancellationTokenSource cts)
        {
            this.cts = cts;
            TimesPlayed++;
            Console.WriteLine("Playing song........");
            await Task.Delay(duration, cts.Token);
            Console.WriteLine($"Song {this.title} has finished");
        }
        
        public override string ToString()
        {
            return $"{this.title} , {this.artist} , {this.duration} , {this.AdditionDate}";
        }

        public void Stop()
        {
            cts.Cancel();
            Console.WriteLine($"Song {this.title} has stoped");

        }
    }
}
