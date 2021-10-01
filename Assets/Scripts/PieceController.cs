using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    // Reference: https://qiita.com/ReoNagai/items/1becdea9e6fa9b55c82a

    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
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
}
