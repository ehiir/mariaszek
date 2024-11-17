using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public static SpriteChanger Instance { get; private set; }
    public SpriteRenderer spriteRenderer; // The SpriteRenderer component on the GameObject
    public List<Sprite> sprites; // A list of sprites to cycle through
    private int currentSpriteIndex = 0; // The index of the current sprite

    void Awake()
    {
        // Implement Singleton Pattern
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
        // Ensure the SpriteRenderer is assigned
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        // Set the initial sprite
        if (sprites.Count > 0)
        {
            spriteRenderer.sprite = sprites[currentSpriteIndex];
        }
        else
        {
            Debug.LogWarning("No sprites assigned to the SpriteChanger script!");
        }
    }

    public void ChangeToNextSprite()
    {
        if (sprites.Count == 0) return;

        // Increment the sprite index
        currentSpriteIndex = (currentSpriteIndex + 1) % sprites.Count;

        // Set the next sprite
        spriteRenderer.sprite = sprites[currentSpriteIndex];
    }
}