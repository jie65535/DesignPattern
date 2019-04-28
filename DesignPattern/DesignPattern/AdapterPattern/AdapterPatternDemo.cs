namespace DesignPattern.AdapterPattern
{
    public class AdapterPatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "beyond the horizon.mp3");
            audioPlayer.Play("mp4", "alone.mp4");
            audioPlayer.Play("vlc", "far far away.vlc");
            audioPlayer.Play("avi", "mind me.avi");
        }
    }
}
