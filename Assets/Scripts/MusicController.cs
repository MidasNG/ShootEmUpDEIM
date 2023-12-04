using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    AudioSource musicSource;
    public AudioMixer mixer;
    void Start()
    {
        musicSource = GetComponent<AudioSource>();   
    }

    void Update()
    {
        if (Time.timeScale == 0) mixer.SetFloat("Lowpass Cutoff freq", 1000);
        else mixer.SetFloat("Lowpass Cutoff freq", 22000);
    }
}
