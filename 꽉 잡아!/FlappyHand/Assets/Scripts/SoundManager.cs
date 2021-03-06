﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource effectSource;
    public AudioSource musicSource;
    public AudioSource pointSource;
    public AudioSource dieSource;
    public static SoundManager instance = null;
    public bool canPlayMusic = true;
    // Start is called before the first frame update
    void Awake()
    {
        if (!instance){
            instance = this;
        }
        else if (instance != this){
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void PlaySingle(AudioClip clip){
        if (!canPlayMusic) return;
        pointSource.clip = clip;
        pointSource.Play();
    }

    public void PlayPointSound(AudioClip clip){
        if (!canPlayMusic) return;
        pointSource.clip = clip;
        pointSource.Play();
    }

    public void PlayDieSound(AudioClip clip){
        if (!canPlayMusic) return;
        dieSource.clip = clip;
        dieSource.Play();
    }

    public void StopPlay(){
        canPlayMusic = false;
        gameObject.SetActive(false);
    }

    public void Play(){
        canPlayMusic = true;
        gameObject.SetActive(true);
    }
}
