using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    internal interface IPlayable
    {
        // abstract method 
        void Play();
    }
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Video.....");
        }
    }
    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing Music.....");
        }
    }
    internal interface TestInterface
    {
        static void Main()
        {
            VideoPlayer v1 = new VideoPlayer();
            v1.Play();
            MusicPlayer m1 = new MusicPlayer();
            m1.Play();
        }
    }
}
