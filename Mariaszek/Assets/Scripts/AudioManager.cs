using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    public List<AudioClip> audioClips;

    private AudioSource audioSource;  
    private int currentClipIndex = 0; 

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        if (audioClips.Count > 0)
        {
            PlayClip(currentClipIndex);  
        }
    }

    public void PlayClip(int index)
    {
        if (audioClips.Count > 0 && index >= 0 && index < audioClips.Count)
        {
            currentClipIndex = index;
            audioSource.clip = audioClips[index];  
            audioSource.Play();  
        }

        else
        {
            Debug.LogWarning("Invalid clip index or empty audio clips list.");
        }
    }

    public void NextClip()
    {
        currentClipIndex = (currentClipIndex + 1) % audioClips.Count;  
        PlayClip(currentClipIndex);  
    }

    public void PreviousClip()
    {
        currentClipIndex = (currentClipIndex - 1 + audioClips.Count) % audioClips.Count;  
        PlayClip(currentClipIndex);  
    }

    public void StopMusic()
    {
        audioSource.Stop(); 
    }

    public void PauseMusic()
    {
        audioSource.Pause();  
    }

    public void ResumeMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.UnPause();  
        }
    }

    public void TurnDownMusic()
    {
        audioSource.volume = 0.5f;
    }
}

