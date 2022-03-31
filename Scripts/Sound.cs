using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ASmallGame.Sounds;
using MoreMountains.Tools;
namespace ASmallGame.Sounds
{
    [System.Serializable]
    public class Sound
    {
        public string Name;
        public AudioClip Clip;
        public AudioClip[] ClipVariations;


        [Range(0f, 1.0f)]
        public float Volume = 1.0f;

        [Range(.1f, 2f)]
        public float Pitch = 1.0f;

        public bool UsePosition;

        [Range(0f, 1.0f)]
        public float VolumeRandomness = 0.0f;

        [Range(0f, 1.0f)]
        public float PitchRandomness = 0.0f;
        public string[] ExtraTriggerNames;
    }
}
