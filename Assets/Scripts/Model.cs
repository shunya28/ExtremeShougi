using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int[,] boardNow = new int[8, 6];
    public BoardTemplate boardTemplate;
    
    void Start()
    {
        this.boardNow = this.boardTemplate.GetNewBoard();
        Show2DArrayInLog(boardNow);
    }

    private void Show2DArrayInLog(int[,] a)
    {
        for(int y = 0; y < 8; y++)
        {
            string buf = "";
            for(int x = 0; x < 6; x++)
            {
                buf += a[y, x] + " ";
            }
            Debug.Log(buf);
        }
    }
}
