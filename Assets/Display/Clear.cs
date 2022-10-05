//  Fonction pour affacer une ligne de la grille.
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Clear {
    // Si une ligne est complète on la supprime et on descend les lignes au dessus
    public static void ClearLine(){
       for (int i = Game.Grid.Count-1 ; i > 0; i--)
       {
            if (testLine(i)) 
            {
                for (int j = i; j > 0; j--)
                {
                    Game.Grid[j] = Game.Grid[j-1];
                }
                GridDisplay.GridToShow();
                GridDisplay.SetColors(Game.ShowTetris);
                ClearLine();
                break; 
            }
       }
    }

    // Cette fonction permet de tester si une ligne est complète et ajoute 150 points au score
    private static bool testLine(int i) {
        for (int j = 0; j < Game.Grid[0].Count; j++)
        {
            if (Game.Grid[i][j] == SquareColor.TRANSPARENT) {return false;}
        }
        Game.Score+=150;
        return true;
    }

    // Vérifie si une ligne est complète et la supprime
    private static void VerifyLineCompleted(){
        for (int i = 0; i < Game.Grid.Count; i++){
            if (!Game.Grid[i].Contains(SquareColor.TRANSPARENT)){
                ClearLine();
            }
        }
    }
}