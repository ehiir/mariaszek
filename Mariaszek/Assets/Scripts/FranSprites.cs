using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class FranSprites : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;

    [YarnCommand("fran1")]
    public void ChangeSprite()
    {
    
        sr.sprite = spriteArray[0];
    }

    [YarnCommand("fran2")]
    public void ChangeSprite1()
    {
    
        sr.sprite = spriteArray[1];
    }
}
