using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class CommandList : MonoBehaviour
{

public class FadeCamera {

    [YarnCommand("fade_camera")]
    public static void Fade() 
    {
        Debug.Log("Fading the camera!");
    }
}


public class ShakeCamera {

    [YarnCommand("shake_camera")]
    public static void shake() 
    {
        CameraShake.Instance.TriggerShake(0.5f, 0.3f);

    }
}


public class playMusic {

    [YarnCommand("play_music")]
    public static void music() 
    {
        Debug.Log("Playing Music");
    }
}


public class changeBckg {

    [YarnCommand("change_background_1")]
    public static void background1() 
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
}