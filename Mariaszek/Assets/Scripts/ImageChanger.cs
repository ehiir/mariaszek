using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;
using UnityEngine.UI;

public class ImageChanger : MonoBehaviour
{
    private Image img;
    public Sprite[] spriteArray;
    Animator backgroundAnimation;

    void Start()
    {
        img = gameObject.GetComponent<Image>();
        backgroundAnimation = gameObject.GetComponent<Animator>();
    }

    [YarnCommand("image1")]
    public void ChangeSprite()
    {
        img.sprite = spriteArray[0];
        backgroundAnimation.SetTrigger("background1");
    }

    [YarnCommand("image2")]
    public void ChangeSprite1()
    {
        img.sprite = spriteArray[1];
        backgroundAnimation.SetTrigger("background2");
    }

    [YarnCommand("image3")]
    public void ChangeSprite2()
    {
        img.sprite = spriteArray[2];
        backgroundAnimation.SetTrigger("background3");
    }

    [YarnCommand("image4")]
    public void ChangeSprite3()
    {
        img.sprite = spriteArray[3];
        backgroundAnimation.SetTrigger("background4");
    }

    [YarnCommand("clear_bg")]
    public void ClearBG()
    {
        img.sprite = spriteArray[4];
        backgroundAnimation.SetTrigger("clear");
    }
}