//  Fonction pour affacer une ligne de la grille.
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Clear {
    // Si une ligne est complète on la supprime et on descend les lignes au dessus
    public static void ClearLine(){
       for (int i = 21 ; i > 0; i--)
       {
            if (testLine(i)) 
            {
                for (int j = i; j > 0; j--)
                {
                    Game.Grid[j] = Game.Grid[j-1];
                }
                Board.GridToShow();
                GridDisplay.SetColors(Game.ShowTetris);
                ClearLine();
                break; 
            }
       }
    }

    private static bool testLine(int i) {
        for (int j = 0; j < 10; j++)
        {
            if (Game.Grid[i][j] == SquareColor.TRANSPARENT) {return false;}
        }
        Game.score+=150;
        return true;
    }

    // Vérifie si une ligne est complète
    private static void VerifyLineCompleted(){
        for (int i = 0; i < 22; i++){
            if (!Game.Grid[i].Contains(SquareColor.TRANSPARENT)){
                ClearLine();
            }
        }
    }
}