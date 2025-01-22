using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class OldPerson : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] spriteArray;

    [YarnCommand("old1")]
    public void ChangeSprite()
    {
        sr.sprite = spriteArray[0];
    }

    [YarnCommand("old2")]
    public void ChangeSprite1()
    {
        sr.sprite = spriteArray[1];
    }

    [YarnCommand("blank")]
    public void ChangeSprite2()
    {
        sr.sprite = spriteArray[2];
    }
}
