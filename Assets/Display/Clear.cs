//  Fonction pour affacer une ligne de la grille.
using System.Collections;
using System.Collections.Generic;
using System;
public class Clear {
    public static void clear(){
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

    // Si une ligne est complète
    public static void ClearLine(){
        for (int i = 0; i < 22; i++){
            int count = 0;
            for (int j = 0; j < 10; j++){
                if (Game.Grid[i][j] != SquareColor.TRANSPARENT){
                    count++;
                }
            }
            if (count == 10){
                for (int k = i; k < 21; k++){
                    Game.Grid[k] = Game.Grid[k+1];
                }
                List<SquareColor> Ligne = new List<SquareColor>();
                for (int j = 0; j < 10; j++){
                    SquareColor color = SquareColor.TRANSPARENT;
                    Ligne.Add(color);
                }
                Game.Grid[21] = Ligne;
                Game.MirrorGrid[21] = new List<SquareColor>(Ligne);
                Game.ShowTetris[21] = new List<SquareColor>(Ligne);
                i--;
            }
        }
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
            if (count == 10){
                Game.score += 100;
            }
        }
    }

    public static void ShowScore(){
        
    }
}