using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace MusicPlayer
{
    internal class Music
    {
        static void Main(string[] args)
        {
            PlayMusic("chiling39-20915");
            Console.WriteLine("Playing music");
            Console.ReadLine();

        }

        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }

        private class SoundPlayer
        {
            public string? SoundLocation { get; internal set; }

            internal void Play()
            {
                throw new NotImplementedException();
            }
        }
    }
}
