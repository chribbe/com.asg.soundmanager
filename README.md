# com.asg.soundmanager
A Small SoundManager for Unity, using MMFeedbacks

Instructions:

1. Add A Small SoundManager in unity package manager
git@github.com:chribbe/com.asg.soundmanager.git
Also make sure FEEL is added to the project 
2. Add a SoundManager, and an MMSoundManager to the scene 
3. Create a SoundBank Assets (Right click in project view SoundManager->SoundBank)
4. Add SoundEntries to the Soundbank
5. Trigger a sound in code:
	SoundManagerPlayEvent.Trigger(soundBankEntry.TriggerName); (needs ASmallGame.Sounds)
	Or with the TriggerSoundComponent on a gameobject
