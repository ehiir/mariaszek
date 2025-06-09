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

    [YarnCommand("image5")]
    public void ChangeSprite4()
    {
        img.sprite = spriteArray[4];
        backgroundAnimation.SetTrigger("background5");
    }

    [YarnCommand("image6")]
    public void ChangeSprite5()
    {
        img.sprite = spriteArray[5];
        backgroundAnimation.SetTrigger("background6");
    }

    [YarnCommand("image7")]
    public void ChangeSprite6()
    {
        img.sprite = spriteArray[6];
        backgroundAnimation.SetTrigger("background7");
    }

    [YarnCommand("image8")]
    public void ChangeSprite7()
    {
        img.sprite = spriteArray[7];
        backgroundAnimation.SetTrigger("background8");
    }

    [YarnCommand("image9")]
    public void ChangeSprite8()
    {
        img.sprite = spriteArray[8];
        backgroundAnimation.SetTrigger("background9");
    }

    [YarnCommand("image10")]
    public void ChangeSprite9()
    {
        img.sprite = spriteArray[9];
        backgroundAnimation.SetTrigger("background10");
    }

    [YarnCommand("image11")]
    public void ChangeSprite10()
    {
        img.sprite = spriteArray[10];
        backgroundAnimation.SetTrigger("background11");
    }

    [YarnCommand("image12")]
    public void ChangeSprite11()
    {
        img.sprite = spriteArray[11];
        backgroundAnimation.SetTrigger("background12");
    }

    [YarnCommand("clear_bg")]
    public void ClearBG()
    {
        img.sprite = spriteArray[12];
        backgroundAnimation.SetTrigger("clear");
    }
}