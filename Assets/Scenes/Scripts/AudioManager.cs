using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;
    public static AudioManager instance;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
           Destroy(gameObject);
           return; 
        }

        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }
    
    public void Start()
    {
        Play("BG");
    }


    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        
        // If the name is not in the array don't play any song.
        // CELUI QUI LIT CECI EST UN CON
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found");
            return; 
        }

        s.source.Play();
    }

    public float GetVolume(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        return s != null ? s.source.volume : 0f;
    }

    public void SetVolume(string name, float volume)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s != null)
        {
            s.source.volume = volume;
        }
    }
}

