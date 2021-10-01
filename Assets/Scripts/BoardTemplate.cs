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

    public void getNewBoard()
    {
        // Decide two boards randomly
        int boardNum1, boardNum2;
        boardNum1 = boardNum2 = Random.Range(0, 10);
        while(boardNum1 == boardNum2)
        {
            boardNum2 = Random.Range(0, 10);
        }
    }
}
