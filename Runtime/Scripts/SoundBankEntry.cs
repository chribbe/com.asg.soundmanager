using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

namespace ASmallGame.Sounds
{
    [System.Serializable]
    public class SoundBankEntry
    {
        public string TriggerName = "";
        public MMSoundManager.MMSoundManagerTracks Track;
        public Sound[] sounds;
        public string[] ExtraTriggerNames;


        void Reset()
        {
            if (sounds == null || sounds.Length == 0)
                sounds = new Sound[1];


        }


        private void OnEnable()
        {
            if (sounds == null || sounds.Length == 0)
                sounds = new Sound[1];

            sounds[1].Volume = 1.0f;
            sounds[1].Pitch = 1.0f;

        }
    }
}
