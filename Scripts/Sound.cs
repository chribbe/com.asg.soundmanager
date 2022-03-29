using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ASmallGame.Sounds;

namespace ASmallGame.Sounds
{
    [System.Serializable]
    public class Sound
    {
        public string name;
        public AudioClip clip;
        public AudioClip[] ClipVariations;


        [Range(0f, 1.0f)]
        public float volume = 1.0f;

        [Range(.1f, 2f)]
        public float pitch = 1.0f;

        public bool usePosition;

        [Range(0f, 1.0f)]
        public float volumeRandomness = 0.0f;

        [Range(0f, 1.0f)]
        public float pitchRandomness = 0.0f;
        public string[] ExtraTriggerNames;




    }
}
