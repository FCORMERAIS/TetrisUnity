using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyBoard{

    public static void MoveRight(){
        List<List<SquareColor>> temp = new List<List<SquareColor>>(Game.MirrorGrid);
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
        GridDisplay.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);

        
    }

    public static void MoveLeft(){
        List<List<SquareColor>> temp = new List<List<SquareColor>>(Game.MirrorGrid);
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
        GridDisplay.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);
    }

    public static void Rush() {
        GridDisplay.SetTickTime(0.03f);
    }
}