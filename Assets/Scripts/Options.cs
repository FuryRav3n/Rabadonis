using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Options : MonoBehaviour
{
    public AudioMixer mikseris;
    public void setMusic(float volume) 
    {
        mikseris.SetFloat("Music", Mathf.Log10(volume) * 20);
    }
    public void setSFX(float volume)
    {
        mikseris.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
}
