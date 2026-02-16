using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip musicClip;
    public AudioClip coinClip, jumpClip, moveClip, dieClip;

    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = musicClip;
        musicSource.Play();
    }

    public void PlaySfx_Coin()
    {
        PlaySfx(coinClip);
    }
    public void PlaySfx_Jump()
    {
        PlaySfx(jumpClip);
    }
    public void PlaySfx_Move()
    {
        PlaySfx(moveClip);
    }
    public void PlaySfx_Die()
    {
        PlaySfx(dieClip);
    }

    void PlaySfx(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.Play();
    }


    public void ToggleMusic(bool off)
    {
        musicSource.mute = off;
    }
    public void ToggleSfx(bool off)
    {
        sfxSource.mute = off;
    }

}
