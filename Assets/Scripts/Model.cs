using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [SerializeField] BoardTemplate boardTemplate;
    [SerializeField] PieceTemplate pieceTemplate;
    private int[,] currentBoard = new int[8, 6];
    private int[][] pieceCard = new int[2][];
    
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
