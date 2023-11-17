using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highlightObject : MonoBehaviour
{
    public Sprite highlightSprite; // Drag your highlight sprite here
    private Sprite originalSprite;
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
    }

    void OnMouseEnter()
    {
        spriteRenderer.sprite = highlightSprite;
    }

    void OnMouseExit()
    {
        spriteRenderer.sprite = originalSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
