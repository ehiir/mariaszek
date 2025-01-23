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
            Debug.Log("Fading the camera!");
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
            Debug.Log("Playing Music");
        }
    }

    public class ChangeBG
    {
        [YarnCommand("change_background_1")]

        public static void Background1() 
        {
            if (SpriteChanger.Instance != null)
            {
                SpriteChanger.Instance.ChangeToNextSprite();
            }
            
            else
            {
                Debug.LogWarning("SpriteChanger instance is not set!");
            }
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
}