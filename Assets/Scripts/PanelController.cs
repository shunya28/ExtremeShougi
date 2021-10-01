using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void HideButtonDown()
    {
        var color = spriteRenderer.color;
        color.a = (color.a == 0) ? 1 : 0;
        spriteRenderer.color = color;
    }
}
