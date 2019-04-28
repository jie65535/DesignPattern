namespace DesignPattern.AdapterPattern
{
    class MediaAdapter : IMediaPlayer
    {
        private readonly IAdvancedMediaPlayer _AdvancedMusicPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType == "vlc")
            {
                _AdvancedMusicPlayer = new VlcPlayer();
            }
            else if (audioType == "mp4")
            {
                _AdvancedMusicPlayer = new Mp4Player();
            }
        }

        public bool Play(string audioType, string fileName)
        {
            if (audioType == "vlc")
            {
                _AdvancedMusicPlayer.PlayVlc(fileName);
            }
            else if (audioType == "mp4")
            {
                _AdvancedMusicPlayer.PlayMp4(fileName);
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
