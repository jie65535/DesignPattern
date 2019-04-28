using System;

namespace DesignPattern.AdapterPattern
{
    public class AudioPlayer : IMediaPlayer
    {
        private MediaAdapter _MediaAdapter;
        public bool Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file. Name: " + fileName);
            }
            else if (audioType == "vlc" || audioType == "mp4")
            {
                _MediaAdapter = new MediaAdapter(audioType);
                _MediaAdapter.Play(audioType, fileName);
            }
            else
            {
                throw new ArgumentException(string.Format("Invalid media. {0} format not supported", audioType), "audioType");
            }
            return true;
        }
    }
}
