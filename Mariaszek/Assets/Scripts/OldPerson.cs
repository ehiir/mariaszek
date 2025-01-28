using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class OldPerson : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;
    Animator dialogueAnimation;

    void Start()
    {
        dialogueAnimation = gameObject.GetComponent<Animator>();
    }

    [YarnCommand("old1")]
    public void ChangeSprite()
    {
        sr.sprite = spriteArray[0];
        dialogueAnimation.SetTrigger("Old1");
    }

    [YarnCommand("old2")]
    public void ChangeSprite1()
    {
        sr.sprite = spriteArray[1];
        dialogueAnimation.SetTrigger("Old2");
    }

    [YarnCommand("Old_blank")]
    public void ChangeSprite2()
    {
        sr.sprite = spriteArray[2];
        dialogueAnimation.SetTrigger("Blank");
    }
}
