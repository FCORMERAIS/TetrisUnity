using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;

public static class KeyBoard{

    public static void MoveRight(){
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            if (Game.MirrorGrid[i][9]!=SquareColor.TRANSPARENT){
                return;
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j=9;j>0;j--){
                if (Game.MirrorGrid[i][j-1]!=SquareColor.TRANSPARENT && Game.Grid[i][j]!=SquareColor.TRANSPARENT ){
                    return;
                }
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j=9;j>0;j--){
                    Game.MirrorGrid[i][j] = Game.MirrorGrid[i][j-1];
            }
            Game.MirrorGrid[i][0] =SquareColor.TRANSPARENT;
        }
        Game.xPiece+=1;
        GridDisplay.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);

        
    }

    public static void MoveLeft(){
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            if (Game.MirrorGrid[i][0]!=SquareColor.TRANSPARENT){
                return;
            }  
        }
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j=0;j<9;j++){
                if (Game.MirrorGrid[i][j+1]!=SquareColor.TRANSPARENT && Game.Grid[i][j]!=SquareColor.TRANSPARENT ){
                    return;
                }
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j=0;j<9;j++){
                Game.MirrorGrid[i][j] = Game.MirrorGrid[i][j+1];
            }
            Game.MirrorGrid[i][9] = SquareColor.TRANSPARENT;

        }
        Game.xPiece-=1;
        GridDisplay.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);
    }

    public static void Rush() {
        GridDisplay.SetTickTime(0.03f);
    }
    
    public static void Rotate(){
        double theta = 90* Math.PI / 180;
        List<int[]> Coor = new List<int[]>();
        for (int i = 0;i<Game.Grid.Count;i++){
            for (int j = 0;j<Game.Grid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!= SquareColor.TRANSPARENT ){
                    double x = Math.Cos(theta) * (j-Game.xPiece) - Math.Sin(theta) * (i-Game.yPiece) + Game.xPiece;
                    double y = Math.Sin(theta) * (j-Game.xPiece) + Math.Cos(theta) * (i-Game.yPiece) + Game.yPiece;
                    if (x > 0 && y > 0 && x < Game.Grid[0].Count && y < Game.Grid.Count && Game.Grid[(int)y][(int)x] == SquareColor.TRANSPARENT){
                        Coor.Add(new int[4]{i,j,(int)x,(int)y});
                    }else{return;}
                }
            }
        }
        for (int i=0;i<22;i++){
            List<SquareColor> Ligne = new List<SquareColor>();
            for (int j = 0;j<10;j++){
                SquareColor color = SquareColor.TRANSPARENT;
                Ligne.Add(color);
            }
            Game.MirrorGrid[i] = new List<SquareColor>(Ligne);
        }
        for (int i = 0;i<Coor.Count;i++){
            Debug.Log(Coor[i][2]+" "+Coor[i][3]+" ");
            Game.MirrorGrid[Coor[i][3]][Coor[i][2]] = Game.Color;
           
            GridDisplay.GridToShow();
            GridDisplay.SetColors(Game.ShowTetris);
            // Thread.Sleep(500);
        }
        
    }
}