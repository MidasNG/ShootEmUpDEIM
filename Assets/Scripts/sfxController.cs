using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfxController : MonoBehaviour
{
    private AudioSource sfxSource;
    [SerializeField] private AudioClip shootSound;

    void Start()
    {
        sfxSource = GetComponent<AudioSource>();
    }

    public void Shoot()
    {
        sfxSource.PlayOneShot(shootSound);
    }
}
