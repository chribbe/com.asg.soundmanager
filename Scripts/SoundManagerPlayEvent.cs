using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace ASmallGame.Sounds
{
    public struct SoundManagerPlayEvent
    {
        public delegate void Delegate(string id, Transform location = null);
        static private event Delegate OnEvent;

        static public void Register(Delegate callback)
        {
            OnEvent += callback;
        }

        static public void Unregister(Delegate callback)
        {
            OnEvent -= callback;
        }

        static public void Trigger(string id, Transform location = null)
        {
            OnEvent?.Invoke(id, location);
        }

    }
}
