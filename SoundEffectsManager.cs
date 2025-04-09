using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GADE_5121_POE_Project_CK
{
    public static class SoundEffectsManager
    {
        public static void PlaySound(string filePath)
        {
            // Check if the file exists to avoid runtime errors
            if (File.Exists(filePath))
            {
                // Create a new SoundPlayer for the effect
                SoundPlayer soundEffect = new SoundPlayer(filePath);
                // Play the sound asynchronously. 
                soundEffect.Play();
            }
        }
    }
}
