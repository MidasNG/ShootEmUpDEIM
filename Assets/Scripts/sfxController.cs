using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxController : MonoBehaviour
{
    private AudioSource sfxSource;
    [SerializeField] private AudioClip shootSound, destroySound;

    void Start()
    {
        sfxSource = GetComponent<AudioSource>();
    }

    public void ShootSFX()
    {
        sfxSource.PlayOneShot(shootSound);
    }

    public void DestroySFX()
    {
        sfxSource.PlayOneShot(destroySound);
    }
}
