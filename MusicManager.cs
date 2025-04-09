using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GADE_5121_POE_Project_CK
{
    public static class MusicManager
    {
        private static SoundPlayer? player; // Make it nullable

        public static void PlayBackgroundMusic(string filePath)
        {
            StopBackgroundMusic(); // Stop any existing music before starting a new one

            if (File.Exists(filePath))
            {
                player = new SoundPlayer(filePath);
                player.PlayLooping(); // Play in a loop
            }
        }

        public static void StopBackgroundMusic()
        {
            if (player != null)
            {
                player.Stop();
                player.Dispose();
                player = null;
            }
        }
    }
}
