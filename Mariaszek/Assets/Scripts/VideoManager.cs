using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public static VideoManager Instance { get; private set; }
    private VideoPlayer videoPlayer;
    public List<VideoClip> videoClips;
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
        videoPlayer = GetComponent<VideoPlayer>();
    }
    
    public void PlayClip(int index)
    {
        if (videoClips.Count > 0 && index >= 0 && index < videoClips.Count)
        {
            currentClipIndex = index;
            videoPlayer.clip = videoClips[index];  
            videoPlayer.Play();  
        }
        else
        {
            Debug.LogWarning("Invalid clip index or empty video clips list.");
        }
    }

    public void NextClip()
    {
        currentClipIndex = (currentClipIndex + 1) % videoClips.Count;  
        PlayClip(currentClipIndex);  
    }

    public void PreviousClip()
    {
        currentClipIndex = (currentClipIndex - 1 + videoClips.Count) % videoClips.Count;  
        PlayClip(currentClipIndex);  
    }
}