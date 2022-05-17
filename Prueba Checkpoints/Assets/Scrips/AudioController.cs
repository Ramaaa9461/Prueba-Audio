using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] List<AudioSource> audioSources;
    [SerializeField] List<AudioSource> soundsSources;

    public void SetVolumenMusic(float volume)
    {
        foreach (AudioSource music in audioSources)
        {
            music.volume = volume;
        }
    }

    public void SetVolumenSounds(float volume)
    {
        foreach (AudioSource sounds in soundsSources)
        {
            sounds.volume = volume;
        }
    }
}
