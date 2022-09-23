using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Clear : MonoBehaviour
{
    public GameObject[] squares;

    // Fonction qui permet de vider la grille entièrement en cas de Game Over
    public void Clear()
    {
        foreach (GameObject square in squares)
        {
            Destroy(square);
        }
    }
    
    public void ClearLines(int line)
    {
        while (true)
        {
            // On parcourt la grille
            for (int i = 0; i < GridDisplay.width; i++)
            {
                for (int j = 0; j < GridDisplay.height; j++)
                {
                    // On vide la grille
                    GridDisplay.SetColor(i, j, Color.clear);
                }
            }
        }
    }

    public void IsLineFull(int line)
    {
        for (int i = 0; i < GridDisplay.width; i++)
        {
            if (GridDisplay.GetColor(i, line) == Color.clear)
            {
                return false;
            }
        }
        return true;
    }
}
