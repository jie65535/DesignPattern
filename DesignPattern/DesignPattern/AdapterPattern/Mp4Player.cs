using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    class Mp4Player : IAdvancedMediaPlayer
    {
        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file. Name: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            ;
        }
    }
}
