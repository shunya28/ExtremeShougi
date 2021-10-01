using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    // Reference of dragging: https://qiita.com/ReoNagai/items/1becdea9e6fa9b55c82a
    // Reference of double click: https://note.com/08_14/n/nd58684fcc519

    private Vector3 screenPoint;
    private Vector3 offset;
    private int touchCount = 0;

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

    // Adjust a piece position to a square
    void OnMouseUp()
    {
        float x = Mathf.Floor(transform.position.x) + 0.5f;
        float y = Mathf.Floor(transform.position.y) + 0.5f;
        transform.position = new Vector3(x, y, 0);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            touchCount++;
            Invoke("ChangePieceImg",0.3f);
        }
    }

    private void ChangePieceImg()
    {
        // Double clicked?
        if(touchCount != 2) { touchCount = 0; return; }     
        else{ touchCount = 0; }

        Debug.Log("double clicked");
    }
}
