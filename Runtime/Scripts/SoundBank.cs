using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ASmallGame.Sounds
{
    [CreateAssetMenu(fileName = "SoundBank", menuName = "SoundManager/SoundBank", order = 1)]
    [System.Serializable]
    public class SoundBank : ScriptableObject
    {
        public SoundBankEntry[] sounds;

       private void Reset()
        {
            if (sounds == null || sounds.Length == 0)
                sounds = new SoundBankEntry[1];

            Debug.Log("RESET?");
        }

    }
}
