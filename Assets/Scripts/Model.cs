using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int[,] currentBoard = new int[8, 6];
    public BoardTemplate boardTemplate;
    
    void Awake()
    {
        this.currentBoard = this.boardTemplate.GetNewBoard();
    }    

    public int[,] GetCurrentBoard()
    {
        return this.currentBoard;
    }
}
