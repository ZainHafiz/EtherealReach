using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer spriteRenderer;
    public bool isActivated = false;
    public UnityEvent on;
    public UnityEvent off;

    public void ChangeState()
    {
        int spriteIndex = Array.IndexOf(sprites, spriteRenderer.sprite);
        spriteRenderer.sprite = sprites[1 - spriteIndex];
        isActivated = !isActivated;
        if (isActivated)
        {
            on.Invoke();
        }
        else
        {
            off.Invoke();
        }
    }
}
