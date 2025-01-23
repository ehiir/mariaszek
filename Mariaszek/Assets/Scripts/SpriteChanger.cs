using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public static SpriteChanger Instance { get; private set; }
    public SpriteRenderer spriteRenderer; 
    public List<Sprite> sprites;
    private int currentSpriteIndex = 0; 

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if (sprites.Count > 0)
        {
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
    }

    public void ChangeToNextSprite()
    {
        if (sprites.Count == 0) return;

        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Count;

        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }
}