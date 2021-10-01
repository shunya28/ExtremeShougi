using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View : MonoBehaviour
{
    public Model model;
    public GameObject squarePrefab;

    void Start()
    {
        int[,] currentBoard = this.model.GetCurrentBoard();

        // Generate a gameboard
        for(int x = 0; x < 8; x++)
        {
            for(int y = 0; y < 6; y++)
            {
                if(currentBoard[x, y] == 0) continue;
                GameObject square = Instantiate(squarePrefab) as GameObject;
                square.transform.position = new Vector3(x - 3.5f, y - 2.5f, 0);
            }
        }
    }
}
