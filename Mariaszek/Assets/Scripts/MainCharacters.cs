using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class MainCharacters : MonoBehaviour
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

    [YarnCommand("ehir1")]
    public void ChangeSprite()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[0];
        dialogueAnimation.SetTrigger("Ehir1");
        Debug.Log("Ehir1 na ekranie");
    }

    [YarnCommand("ehir2")]
    public void ChangeSprite1()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[1];
        dialogueAnimation.SetTrigger("Ehir2"); 
        Debug.Log("Ehir2 na ekranie");
    }

    [YarnCommand("ehir3")]
    public void ChangeSprite2()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[2];
        dialogueAnimation.SetTrigger("Ehir3"); 
        Debug.Log("Ehir3 na ekranie");
    }

    [YarnCommand("fran1")]
    public void ChangeSprite3()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[3];
        dialogueAnimation.SetTrigger("Fran1"); 
        Debug.Log("Fran1 na ekranie");
    }

    [YarnCommand("fran2")]
    public void ChangeSprite4()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[4];
        dialogueAnimation.SetTrigger("Fran2"); 
        Debug.Log("Fran2 na ekranie");
    }

    [YarnCommand("fran3")]
    public void ChangeSprite5()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[5];
        dialogueAnimation.SetTrigger("Fran3"); 
        Debug.Log("Fran3 na ekranie");
    }

    [YarnCommand("labuda1")]
    public void ChangeSprite6()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[6];
        dialogueAnimation.SetTrigger("Labuda1"); 
        Debug.Log("Labuda1 na ekranie");
    }

    [YarnCommand("labuda2")]
    public void ChangeSprite7()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[7];
        dialogueAnimation.SetTrigger("Labuda2"); 
        Debug.Log("Labuda2 na ekranie");
    }

    [YarnCommand("labuda3")]
    public void ChangeSprite8()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[8];
        dialogueAnimation.SetTrigger("Labuda3"); 
        Debug.Log("Labuda3 na ekranie");
    }

    [YarnCommand("nika1")]
    public void ChangeSprite9()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[9];
        dialogueAnimation.SetTrigger("Nika1"); 
        Debug.Log("Nika1 na ekranie");
    }

    [YarnCommand("nika2")]
    public void ChangeSprite10()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[10];
        dialogueAnimation.SetTrigger("Nika2"); 
        Debug.Log("Nika2 na ekranie");
    }

    [YarnCommand("nika3")]
    public void ChangeSprite11()
    {
        shadow.SetActive(true);

        sr.sprite = spriteArray[11];
        dialogueAnimation.SetTrigger("Nika3"); 
        Debug.Log("Nika3 na ekranie");
    }

    [YarnCommand("PC_blank")]
    public void ChangeSprite12()
    {
        shadow.SetActive(false);

        sr.sprite = spriteArray[12];
        dialogueAnimation.SetTrigger("Blank"); 
        Debug.Log("Nic na ekranie");
    }
}