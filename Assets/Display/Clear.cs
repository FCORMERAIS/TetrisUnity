//  Fonction pour affacer une ligne de la grille.
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Clear {
    public static void clearGrid(){
        List<List<SquareColor>> board = new List<List<SquareColor>>(); 
        // si une forme touche le haut
        for (int i = 0; i < 22; i++){
            List<SquareColor> Ligne = new List<SquareColor>();
            for (int j = 0; j < 10; j++){
                SquareColor color = SquareColor.TRANSPARENT;
                Ligne.Add(color);
            }
            Game.Grid[i] = Ligne;
            Game.MirrorGrid[i] = new List<SquareColor>(Ligne);
            Game.ShowTetris[i] = new List<SquareColor>(Ligne);
        }
    }

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
                GridDisplay.GridToShow();
                GridDisplay.SetColors(Game.ShowTetris);
                ClearLine();
                break; 
            }
       }
    }

    public static bool testLine(int i) {
        for (int j = 0; j < 10; j++)
        {
            if (Game.Grid[i][j] == SquareColor.TRANSPARENT) {return false;}
        }
        Game.score+=150;
        return true;
    }

    // Vérifie si une ligne est complète
    public static void VerifyLineCompleted(){
        for (int i = 0; i < 22; i++){
            int count = 0;
            for (int j = 0; j < 10; j++){
                if (Game.Grid[i][j] != SquareColor.TRANSPARENT){
                    count++;
                }
            }
           
        }
    }
}