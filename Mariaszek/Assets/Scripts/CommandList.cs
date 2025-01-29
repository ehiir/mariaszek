using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class CommandList : MonoBehaviour
{
    public class FadeCamera
    {
        [YarnCommand("fade_camera")]

        public static void Fade() 
        {
            CameraFade.Instance.TriggerFade(); 
        }
    }

    public class ShakeCamera
    {
        [YarnCommand("shake_camera")]

        public static void Shake() 
        {
            CameraShake.Instance.TriggerShake();
        }
    }

    public class PlayMusic
    {
        [YarnCommand("play_music")]

        public static void Music() 
        {
            AudioManager.Instance.NextClip();
        }
    }

    public class LowVolume
    {
        [YarnCommand("turndown_music")]

        public static void Volume() 
        {
            AudioManager.Instance.TurnDownMusic();
        }
    }

    public class LoadScene
    {
        [YarnCommand("load_scene")]

        public static void Scene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public class FreezeTime
    {
        [YarnCommand("freeze_time")]

        public static void Pause()
        {
            Time.timeScale = 0f;
        }
    }

    public class DefrostTime
    {
        [YarnCommand("defrost_time")]

        public static void Play()
        {
            Time.timeScale = 1f;
        }
    }

    public class FreezePlayer
    {
        [YarnCommand("freeze_player")]
        public static void Freeze()
        {
            Debug.Log("freeze_player command triggered!");

            if (PlayerMovement.Instance != null)
            {
                PlayerMovement.Instance.FreezeMovement();
            }

            else
            {
                Debug.LogWarning("PlayerMovement instance is not set!");
            }
        }
    }

    public class DefrostPlayer
    {
        [YarnCommand("defrost_player")]

        public static void Defrost()
        {
            if (PlayerMovement.Instance != null)
            {
                PlayerMovement.Instance.DefrostMovement();
            }
            
            else
            {
                Debug.LogWarning("PlayerMovement instance is not set!");
            }
        }
    }
}