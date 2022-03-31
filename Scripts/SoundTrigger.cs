using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ASmallGame.Sounds;
public class SoundTrigger : MonoBehaviour
{
    public TriggerFunctions Trigger;
    public string SoundName;


    public enum TriggerFunctions { OnEnable, Awake, Start, OnDisable };

    // Start is called before the first frame update
    void Start()
    {
        if(Trigger == TriggerFunctions.Start)
        {
            trigger();
        }
    }

    void Awake()
    {
        if (Trigger == TriggerFunctions.Awake)
        {
            trigger();
        }
    }

    void OnEnable()
    {
        if (Trigger == TriggerFunctions.OnEnable)
        {
            trigger();
        }
    }

    void OnDisable()
    {
        if (Trigger == TriggerFunctions.OnDisable)
        {
            trigger();
        }
    }


    void trigger()
    {
        SoundManagerPlayEvent.Trigger(SoundName);

    }
}


