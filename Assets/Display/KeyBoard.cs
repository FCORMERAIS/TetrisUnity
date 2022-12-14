using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public static class KeyBoard{

    // Cette fonction permet de déplacer la pièce vers la gauche
    public static void MoveRight(){
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            if (Game.MirrorGrid[i][Game.MirrorGrid[0].Count-1]!=SquareColor.TRANSPARENT){
                return;
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j=Game.MirrorGrid[0].Count-1;j>0;j--){
                if (Game.MirrorGrid[i][j-1]!=SquareColor.TRANSPARENT && Game.Grid[i][j]!=SquareColor.TRANSPARENT ){
                    return;
                }
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j=Game.MirrorGrid[0].Count-1;j>0;j--){
                    Game.MirrorGrid[i][j] = Game.MirrorGrid[i][j-1];
            }
            Game.MirrorGrid[i][0] =SquareColor.TRANSPARENT;
        }
        Game.xPiece+=1;
        if (Board.IsFloorTouch()) {
            Board.FloorTouch();
            Clear.ClearLine();
            Board.IsGameOver();
        }
        Board.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);
    }

    // Cette fonction permet de déplacer la pièce vers la droite
    public static void MoveLeft(){
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            if (Game.MirrorGrid[i][0]!=SquareColor.TRANSPARENT){
                return;
            }  
        }
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j=0;j<Game.MirrorGrid[0].Count-1;j++){
                if (Game.MirrorGrid[i][j+1]!=SquareColor.TRANSPARENT && Game.Grid[i][j]!=SquareColor.TRANSPARENT ){
                    return;
                }
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j=0;j<Game.MirrorGrid[0].Count-1;j++){
                Game.MirrorGrid[i][j] = Game.MirrorGrid[i][j+1];
            }
            Game.MirrorGrid[i][Game.MirrorGrid[0].Count-1] = SquareColor.TRANSPARENT;

        }
        Game.xPiece-=1;
        if (Board.IsFloorTouch()) {
            Board.FloorTouch();
            Clear.ClearLine();
            Board.IsGameOver();
        }
        Board.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);
    }

    // Cette fonction permet de faire descendre une pièce complétement
    public static void Rush() {
        GridDisplay.SetTickTime(0.03f);
    }
    
    // Cette fonction permet de faire tourner une pièce
    public static void Rotate(){
        if(Game.Color == SquareColor.PURPLE){
            return;
        }
        List<int[]> Coor = new List<int[]>();
        for (int i = 0;i<Game.Grid.Count;i++){
            for (int j = 0;j<Game.Grid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!= SquareColor.TRANSPARENT ){
                    int x = i+Game.xPiece-Game.yPiece;
                    int y = Game.xPiece+Game.yPiece-j;
                    if (x >= 0 && y >= 0 && x < Game.Grid[0].Count && y < Game.Grid.Count && Game.Grid[(int)y][(int)x] == SquareColor.TRANSPARENT){
                        Coor.Add(new int[4]{i,j,(int)x,(int)y});
                    }else{return;}
                }
            }
        }
        for (int i=0;i<Game.MirrorGrid.Count;i++){
            List<SquareColor> Ligne = new List<SquareColor>();
            for (int j = 0;j<Game.MirrorGrid[0].Count;j++){
                SquareColor color = SquareColor.TRANSPARENT;
                Ligne.Add(color);
            }
            Game.MirrorGrid[i] = new List<SquareColor>(Ligne);
        }
        for (int i = 0;i<Coor.Count;i++){
            Game.MirrorGrid[Coor[i][3]][Coor[i][2]] = Game.Color;
            Board.GridToShow();
            GridDisplay.SetColors(Game.ShowTetris);
        }
    }
}