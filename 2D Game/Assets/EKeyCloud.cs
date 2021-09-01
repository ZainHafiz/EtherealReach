using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EKeyCloud : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Interact interact;

    void Update()
    {
        if (interact.isInRange)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
}
