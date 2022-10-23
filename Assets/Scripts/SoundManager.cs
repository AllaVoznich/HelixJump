using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioClip AudioClip;
    public AudioClip BounceAudio;
    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    public void PlaySound()
    {
        _audio.PlayOneShot(AudioClip);
    }

    public void PlayBounceSound()
    {
        _audio.PlayOneShot(BounceAudio);
    }
}

