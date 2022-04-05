using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using UnityEngine.Events;
using System.Linq;
namespace ASmallGame.Sounds
{
    public class SoundManager : MonoBehaviour
    {
        public bool DebugDisplay;
        public SoundBank SoundBank;

        void OnEnable()
        {
            Debug.Log("SoundManager Init");
            SoundManagerPlayEvent.Register(onSoundPlayEvent);


            foreach (Sound s in SoundBank.sounds)
            {
                s.Reset();
            }
        }
        void OnDisable()
        {
            SoundManagerPlayEvent.Unregister(onSoundPlayEvent);
        }

        public void Play(string soundId,Transform location = null)
        {
            List<Sound> soundsToPlay = new List<Sound>();


            foreach (Sound s in SoundBank.sounds)
            {
                if(s.Name == soundId)
                {
                    soundsToPlay.Add(s);
                }

                if (s.ExtraTriggerNames.Any(soundId.Contains))
                {
                    soundsToPlay.Add(s);
                }
            }

            if(soundsToPlay.Count > 0)
            {
                foreach (Sound s in soundsToPlay)
                {
                    playSound(s,location);
                }
            }
            else
            {
                Debug.Log("[SoundManager]Sound Not Found: " + soundId);
            }
        }

        private void playSound(Sound sound, Transform location)
        {
            MMSoundManagerPlayOptions options;
            // we initialize it with the default values
            options = MMSoundManagerPlayOptions.Default;
            options.Volume = sound.Volume;// + (Random.Range(sound.Volume, sound.Volume + sound.VolumeRandomness) - sound.VolumeRandomness / 2);

            if(sound.UsePosition && location != null)
            {
                options.Location = location.position;

            }
            if (sound.PitchRandomness > 0)
            {
                options.Pitch = Random.Range(sound.Pitch, sound.Pitch + sound.PitchRandomness) - sound.PitchRandomness / 2;
            } else
            {
                options.Pitch = sound.Pitch;
            }

            if (sound.VolumeRandomness > 0)
            {
                options.Volume = Random.Range(sound.Volume, sound.Volume  + sound.VolumeRandomness) - sound.VolumeRandomness/2;
            }
            else
            {
                options.Volume = sound.Volume;
            }


            if(sound.Delay > 0)
            {
                StartCoroutine(sound.WaitAndPlaySound(options,sound.Delay));

            } else
            {
                sound.Play(options);
            }

        }

        void onSoundPlayEvent(string id, Transform location = null)
        {
            Debug.Log("[SoundManager] Play Sound: " + id);
            Play(id, location);
        }

    }

}
