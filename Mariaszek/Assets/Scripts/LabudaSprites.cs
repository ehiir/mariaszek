using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class LabudaSprites : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;

    [YarnCommand("labuda1")]
    public void ChangeSprite()
    {
    
        sr.sprite = spriteArray[0];
    }

    [YarnCommand("labuda2")]
    public void ChangeSprite1()
    {
    
        sr.sprite = spriteArray[1];
    }
}