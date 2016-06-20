using System;
using System.Media;
using MorseCodeRain.Properties;

namespace MorseCodeRain
{
    class GameSoundPlayer : IDisposable
    {
        private readonly SoundPlayer soundPlayer = new SoundPlayer();

        public void PlayRandomDrip()
        {
            var random = new Random();
            int randomNum = random.Next(1, 6);

            switch (randomNum)
            {
                case 1: soundPlayer.Stream = Resources.Drip_01; break;
                case 2: soundPlayer.Stream = Resources.Drip_02; break;
                case 3: soundPlayer.Stream = Resources.Drip_03; break;
                case 4: soundPlayer.Stream = Resources.Drip_04; break;
                case 5: soundPlayer.Stream = Resources.Drip_05; break;
            }

            soundPlayer.Play();
        }

        public void PlayFail()
        {
            soundPlayer.Stream = Resources.Wrong;
            soundPlayer.Play();
        }

        public void PlayCorrect()
        {
            soundPlayer.Stream = Resources.Right;
            soundPlayer.Play();
        }

        public void Dispose()
        {
            soundPlayer.Dispose();
        }
    }
}
