using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public Model model;
    public GameObject squarePrefab;
    public GameObject[] piecesPrefab;

    void Start()
    {
        // Generate a gameboard
        int[,] currentBoard = this.model.GetCurrentBoard();
        for(int x = 0; x < 8; x++)
        {
            for(int y = 0; y < 6; y++)
            {
                if(currentBoard[x, y] == 0) continue;
                GameObject square = Instantiate(squarePrefab) as GameObject;
                square.transform.position = new Vector3(x - 3.5f, y - 2.5f, 0);
            }
        }
        
        // Generate pieces
        int[][] pieceCard = this.model.GetPieceCard();
        for(int i = 0; i < 2; i++)
        {
            float angle = (i == 0) ? -90.0f : 90.0f;
            for(int j = 0; j < 5; j++)
            {
                GameObject piece = Instantiate(piecesPrefab[pieceCard[i][j]]) as GameObject;
                piece.transform.position = new Vector3(-5.5f + i * 11.0f, (2.5f - j * 1.0f) * Mathf.Pow(-1.0f, i) , 0);
                piece.transform.Rotate(0, 0, angle);
            }
        }
    }
}
