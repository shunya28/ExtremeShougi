using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardTemplate : MonoBehaviour
{
    private int[,,] boards = new int[,,]
    {
        {{0,1,1,1,0,0},
         {0,1,0,1,1,0},
         {0,1,1,1,1,0},
         {0,0,0,0,0,0}},  // 0

        {{0,1,1,1,1,0},
         {0,1,1,1,1,0},
         {0,0,1,1,0,0},
         {0,0,0,0,0,0}},  // 1

        {{0,0,1,1,0,0},
         {1,1,1,1,1,1},
         {0,0,1,1,0,0},
         {0,0,0,0,0,0}},  // 2

        {{1,1,1,1,1,1},
         {1,1,0,0,1,1},
         {0,0,0,0,0,0},
         {0,0,0,0,0,0}},  // 3

        {{0,0,1,1,0,0},
         {0,0,1,1,0,0},
         {0,0,1,1,1,0},
         {0,0,0,1,1,1}},  // 4

        {{0,1,1,1,1,0},
         {0,0,1,1,1,0},
         {0,0,0,1,1,0},
         {0,0,0,0,1,0}},  // 5

        {{0,1,1,1,1,0},
         {0,1,0,0,1,0},
         {0,1,1,1,1,0},
         {0,0,0,0,0,0}},  // 6
        
        {{0,1,1,1,1,0},
         {1,1,1,1,1,1},
         {0,0,0,0,0,0},
         {0,0,0,0,0,0}},  // 7

        {{0,0,1,1,0,0},
         {0,0,1,1,1,1},
         {0,0,1,1,0,0},
         {0,0,0,1,1,0}},  // 8

        {{1,1,1,1,1,1},
         {0,0,1,1,0,0},
         {0,0,1,1,0,0},
         {0,0,0,0,0,0}}  // 9
    };

    void Start()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
    }

    public int[,] getNewBoard()
    {
        // Decide two boards randomly
        int boardNum1, boardNum2;
        boardNum1 = boardNum2 = Random.Range(0, 10);
        while(boardNum1 == boardNum2)
        {
            boardNum2 = Random.Range(0, 10);
        }

        // Merge the two boards
        int[,] newBoard = new int[8, 6];
        for(int y = 0; y < 4; y++)
        {
            for(int x = 0; x < 6; x++)
            {
                // Set a board upside down
                newBoard[y, x] = this.boards[boardNum1, 3 - y, 5 - x];
            }
        }
        for(int y = 4; y < 8; y++)
        {
            for(int x = 0; x < 6; x++)
            {
                // Set a board at the latter half of newBoard
                newBoard[y, x] = this.boards[boardNum2, y + 3, x];
            }
        }

        return newBoard;
    }
}
