using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{

    public AudioSource SFX;
    public AudioSource Music;
    public AudioSource Environment;

    public AudioClip Intro;

    public AudioClip ButtonHover;
    public AudioClip ButtonClick;

    public void PlayButtonHover()
    {
        SFX.clip = ButtonHover;
        SFX.Play();
    }
    public void PlayButtonClick()
    {
        SFX.clip = ButtonClick;
        SFX.Play();
    }

    public void FadeOutSound()
    {
      
    }

}

