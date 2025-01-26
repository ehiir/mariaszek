using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer sr; 
    public Sprite[] spriteArray;
    Animator backgroundAnimation;

    void Start()
    {
        backgroundAnimation = gameObject.GetComponent<Animator>();
    }


    [YarnCommand("bg1")]
    public void ChangeSprite()
    {
        sr.sprite = spriteArray[0];
        backgroundAnimation.SetTrigger("background1");
        
    }

    [YarnCommand("bg2")]
    public void ChangeSprite1()
    {
        sr.sprite = spriteArray[1];
        backgroundAnimation.SetTrigger("background2");
    }

    [YarnCommand("bg3")]
    public void ChangeSprite2()
    {
        sr.sprite = spriteArray[2];
        backgroundAnimation.SetTrigger("background3");
    }
}