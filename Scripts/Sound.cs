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
       // public string Name;
        public AudioClip Clip;
        public AudioClip[] ClipVariations;

        [Range(0f, 1.0f)]
        public float Volume = 1.0f;

        [Range(.1f, 2f)]
        public float Pitch = 1.0f;

        public float CoolDown = 0.1f;
        public float Delay = 0.0f;

        public bool UsePosition;

        [Range(0f, 1.0f)]
        public float VolumeRandomness = 0.0f;

        [Range(0f, 1.0f)]
        public float PitchRandomness = 0.0f;

        private float _lastPlayedTime = 0.0f;


        public AudioClip GetClip()
        {

            if(ClipVariations.Length > 0)
            {
                AudioClip c = ClipVariations[Random.Range(0, ClipVariations.Length)];

                if(c != null)
                    return c;
            }
            
            return Clip;
        }

        public bool Play(MMSoundManagerPlayOptions options)
        {
      
            if (Time.time - _lastPlayedTime < CoolDown) return false; 

            MMSoundManagerSoundPlayEvent.Trigger(GetClip(), options);            
            _lastPlayedTime = Time.time;
            return true;
        }

        public IEnumerator WaitAndPlaySound(MMSoundManagerPlayOptions options,float delay) 
        {
            
            yield return new WaitForSeconds(delay);
            MMSoundManagerSoundPlayEvent.Trigger(GetClip(), options);

            if (Time.time - _lastPlayedTime > CoolDown)
            {
                _lastPlayedTime = Time.time;
            }
        }


        public void Reset()
        {
            this.Volume = 1.0f;
            this.Pitch = 1.0f;
            this.PitchRandomness = 0.0f;
            this.VolumeRandomness = 0.0f;
            _lastPlayedTime = 0.0f;
        }

    }
}
