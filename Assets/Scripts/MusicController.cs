using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    AudioSource musicSource;
    public AudioClip clip;
    public AudioMixer mixer;
    void Start()
    {
        musicSource = GetComponent<AudioSource>();    
    }

    // Update is called once per frame
    void Update()
    {
        mixer.SetFloat("Lowpass Cutoff freq", 500);
        //musicSource.PlayOneShot(clip);
    }
}
