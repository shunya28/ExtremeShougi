using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int[,] currentBoard = new int[8, 6];
    public BoardTemplate boardTemplate;
    
    void Start()
    {
        this.currentBoard = this.boardTemplate.GetNewBoard();
        Show2DArrayInLog(currentBoard);
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

    public int[,] GetCurrentBoard()
    {
        return this.currentBoard;
    }
}
