using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MainCharacters : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    Animator dialogueAnimation;

     void Start()
    {
        dialogueAnimation = gameObject.GetComponent<Animator>();
    }

    [YarnCommand("ehir1")]
    public void ChangeSprite()
    {
        sr.sprite = spriteArray[0];
        // dialogueAnimation.SetTrigger("Ehir1");
        Debug.Log("Ehir1 na ekranie") ;
    }

    [YarnCommand("ehir2")]
    public void ChangeSprite1()
    {
        sr.sprite = spriteArray[1];
        // dialogueAnimation.SetTrigger("Ehir2"); 
        Debug.Log("Ehir2 na ekranie");
    }

    [YarnCommand("fran1")]
    public void ChangeSprite2()
    {
        sr.sprite = spriteArray[2];
        dialogueAnimation.SetTrigger("Fran1"); 
        Debug.Log("Fran1 na ekranie");
    }

    [YarnCommand("fran2")]
    public void ChangeSprite3()
    {
        sr.sprite = spriteArray[3];
        dialogueAnimation.SetTrigger("Fran2"); 
        Debug.Log("Fran2 na ekranie");
    }

    [YarnCommand("labuda1")]
    public void ChangeSprite4()
    {
        sr.sprite = spriteArray[4];
        dialogueAnimation.SetTrigger("Labuda1"); 
        Debug.Log("Labuda1 na ekranie");
    }

    [YarnCommand("labuda2")]
    public void ChangeSprite5()
    {
        sr.sprite = spriteArray[5];
        dialogueAnimation.SetTrigger("Labuda2"); 
        Debug.Log("Labuda2 na ekranie");
    }

    [YarnCommand("nika1")]
    public void ChangeSprite6()
    {
        sr.sprite = spriteArray[6];
        // dialogueAnimation.SetTrigger("Nika1"); 
        Debug.Log("Nika1 na ekranie");
    }

    [YarnCommand("nika2")]
    public void ChangeSprite7()
    {
        sr.sprite = spriteArray[7];
        // dialogueAnimation.SetTrigger("Nika2"); 
        Debug.Log("Nika2 na ekranie");
    }

    [YarnCommand("PC_blank")]
    public void ChangeSprite8()
    {
        sr.sprite = spriteArray[8];
        dialogueAnimation.SetTrigger("Blank"); 
        Debug.Log("Nic na ekranie");
    }
}
