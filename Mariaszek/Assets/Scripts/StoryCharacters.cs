using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class StoryCharacters : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    Animator dialogueAnimation;

    public GameObject shadow;

    void Start()
    {
        dialogueAnimation = gameObject.GetComponent<Animator>();
        shadow.SetActive(false);
    }

    [YarnCommand("old1")]
    public void ChangeSprite13()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[0];
        dialogueAnimation.SetTrigger("Old1");
        Debug.Log("Stary1 na ekranie");
    }

    [YarnCommand("old2")]
    public void ChangeSprite14()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[1];
        dialogueAnimation.SetTrigger("Old2");
        Debug.Log("Stary2 na ekranie");
    }

    [YarnCommand("mareczek1")]
    public void ChangeSprite15()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[2];
        dialogueAnimation.SetTrigger("Mareczek1"); 
        Debug.Log("Mareczek1 na ekranie");
    }

    [YarnCommand("mareczek2")]
    public void ChangeSprite16()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[3];
        dialogueAnimation.SetTrigger("Mareczek2"); 
        Debug.Log("Mareczek2 na ekranie");
    }

    [YarnCommand("detektyw1")]
    public void ChangeSprite17()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[4];
        dialogueAnimation.SetTrigger("Detektyw1"); 
        Debug.Log("Detektyw1 na ekranie");
    }

    [YarnCommand("detektyw2")]
    public void ChangeSprite18()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[5];
        dialogueAnimation.SetTrigger("Detektyw2"); 
        Debug.Log("Detektyw2 na ekranie");
    }

    [YarnCommand("tarociara1")]
    public void ChangeSprite19()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[6];
        dialogueAnimation.SetTrigger("Tarociara1"); 
        Debug.Log("Tarociara1 na ekranie");
    }

    [YarnCommand("tarociara2")]
    public void ChangeSprite20()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[7];
        dialogueAnimation.SetTrigger("Tarociara2"); 
        Debug.Log("Tarociara2 na ekranie");
    }

    [YarnCommand("ardenia1")]
    public void ChangeSprite21()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[8];
        dialogueAnimation.SetTrigger("Ardenia1"); 
        Debug.Log("Ardenia1 na ekranie");
    }

    [YarnCommand("ardenia2")]
    public void ChangeSprite22()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[9];
        dialogueAnimation.SetTrigger("Ardenia2"); 
        Debug.Log("Ardenia2 na ekranie");
    }

    [YarnCommand("HotelOwner1")]
    public void ChangeSprite23()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[10];
        dialogueAnimation.SetTrigger("HotelOwner1"); 
        Debug.Log("HotelOwner1 na ekranie");
    }

    [YarnCommand("HotelOwner2")]
    public void ChangeSprite24()
    {
        shadow.SetActive(true);
        
        sr.sprite = spriteArray[11];
        dialogueAnimation.SetTrigger("HotelOwner2"); 
        Debug.Log("HotelOwner2 na ekranie");
    }

    [YarnCommand("NPC_blank")]
    public void ChangeSprite25()
    {
        shadow.SetActive(false);

        sr.sprite = spriteArray[12];
        dialogueAnimation.SetTrigger("Blank"); 
        Debug.Log("Nic na ekranie");
    }
}