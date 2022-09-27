using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class KeyBoard{

    public static void MoveRight(){
        List<List<SquareColor>> temp = Game.MirrorGrid;
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (temp[i][j]!=SquareColor.TRANSPARENT){
                    if (j>0){
                        Game.MirrorGrid[i][j-1] = temp[i][j];
                        Game.MirrorGrid[i][j] = SquareColor.TRANSPARENT;
                    }else{return;}
                }
            }
        }
    }

    public static void MoveLeft(){
        List<List<SquareColor>> temp = Game.MirrorGrid;
        
        for (int i = 0;i<Game.MirrorGrid.Count-1;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!=SquareColor.TRANSPARENT ){
                    if (j<Game.MirrorGrid[0].Count-1){
                    Game.MirrorGrid[i][j+1] = temp[i][j];
                    Game.MirrorGrid[i][j] = SquareColor.TRANSPARENT;
                    }else {return;}
                }
            }
        }
    }

    public static void Rush() {
        GridDisplay.SetTickTime(0.03f);
    }
}