using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    // Reference of dragging: https://qiita.com/ReoNagai/items/1becdea9e6fa9b55c82a
    // Reference of double click: https://note.com/08_14/n/nd58684fcc519

    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    private Vector3 screenPoint;
    private Vector3 offset;
    private int touchCount = 0;
    private bool isBack = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

        // A process for checking double click
        touchCount++;
        Invoke("ChangePieceImg",0.3f);
    }

    void OnMouseDrag()
    {
        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint);
        transform.position = currentPosition;
    }

    void OnMouseUp()
    {
        float x = Mathf.Floor(transform.position.x) + 0.5f;
        float y = Mathf.Floor(transform.position.y) + 0.5f;
        transform.position = new Vector3(x, y, 0);
    }
    
    private void ChangePieceImg()
    {
        // Double-clicked?
        if(touchCount != 2)
        {
            touchCount = 0;
            return;
        }     
        else
        {
            touchCount = 0;
        }

        // Change a piece image
        if(isBack)
        {
            spriteRenderer.sprite = frontSprite;
            transform.Rotate(0, 0, 180.0f);
            isBack = false;
        }
        else
        {
            // If a piece does not have a back image, just rotate it
            if(backSprite == null)
            {
                transform.Rotate(0, 0, 180.0f);
            }
            else
            {
                spriteRenderer.sprite = backSprite;
                isBack = true;
            }
        }
    }
}
