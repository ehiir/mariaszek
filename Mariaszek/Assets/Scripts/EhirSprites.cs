using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class EhirSprites : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;

    [YarnCommand("ehir1")]
    public void ChangeSprite()
    {
    
        sr.sprite = spriteArray[0];
    }

    [YarnCommand("ehir2")]
    public void ChangeSprite1()
    {
    
        sr.sprite = spriteArray[1];
    }
}
