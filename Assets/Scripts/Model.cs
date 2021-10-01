using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    private int[,] currentBoard = new int[8, 6];
    private int[][] pieceCard = new int[2][];
    public BoardTemplate boardTemplate;
    public PieceTemplate pieceTemplate;
    
    void Awake()
    {
        this.currentBoard = this.boardTemplate.GetNewBoard();
        this.pieceCard = this.pieceTemplate.GetNewPieceCard();
    }    

    public int[,] GetCurrentBoard()
    {
        return this.currentBoard;
    }

    public int[][] GetPieceCard()
    {
        return this.pieceCard;
    }
}
