using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ASmallGame.Sounds
{
    [CreateAssetMenu(fileName = "SoundBank", menuName = "SoundManager/SoundBank", order = 1)]
    public class SoundBank : ScriptableObject
    {
        public AudioMixerGroup mixerGroup;
        public Sound[] sounds;

        private void OnEnable()
        {
            if (sounds == null || sounds.Length == 0)
                sounds = new Sound[1];
        }

    }
}
