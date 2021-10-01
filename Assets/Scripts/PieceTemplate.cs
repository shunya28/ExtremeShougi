using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceTemplate : MonoBehaviour
{
    // 1: ou, 2: hisha, 3: kaku, 4: kin
    // 5: gin, 6: kei, 7: kyou, 8: fu
    private int[][] pieces = new int[][]
    {
        new int[] {8,8,6,2,1},
        new int[] {8,6,5,3,1},
        new int[] {8,6,6,4,1},
        new int[] {8,7,6,5,1},
        new int[] {8,7,7,7,1},
        new int[] {8,8,5,4,1}
    };

    void Awake()
    {
        Random.InitState(System.DateTime.Now.Millisecond);
    }

    public int[][] GetNewPieceCard()
    {
        // Decide two combinations of pieces randomly
        int pieceNum1, pieceNum2;
        pieceNum1 = pieceNum2 = Random.Range(0, 6);
        while(pieceNum1 == pieceNum2)
        {
            pieceNum2 = Random.Range(0, 6);
        }

        int[][] pieceCard = new int[][] {this.pieces[pieceNum1], this.pieces[pieceNum2]};

        return pieceCard;
    }
}
