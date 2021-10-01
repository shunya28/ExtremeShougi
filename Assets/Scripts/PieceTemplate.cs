using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceTemplate : MonoBehaviour
{
    // 0: ou, 1: hisha, 2: kaku, 3: kin
    // 4: gin, 5: kei, 6: kyou, 7: fu
    private int[][] pieces = new int[][]
    {
        new int[] {7,7,5,1,0},
        new int[] {7,5,4,2,0},
        new int[] {7,5,5,3,0},
        new int[] {7,6,5,4,0},
        new int[] {7,6,6,6,0},
        new int[] {7,7,4,3,0}
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
