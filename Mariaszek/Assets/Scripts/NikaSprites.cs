using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class NikaSprites : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;

    [YarnCommand("nika1")]
    public void ChangeSprite()
    {
    
        sr.sprite = spriteArray[0];
    }

    [YarnCommand("nika2")]
    public void ChangeSprite1()
    {
    
        sr.sprite = spriteArray[1];
    }
}
