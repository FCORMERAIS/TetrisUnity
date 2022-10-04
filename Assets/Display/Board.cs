using System;
using System.Collections;
using System.Collections.Generic;
using Unity = UnityEngine;

public class Board{
    public static void SpawnPiece(){
        Random rnd = new Random();
        String[] Shape = {"S","Z","T","O","I","L","J"};
        int random = rnd.Next(0, Shape.Length);
        String takeRnd = Shape[random];
        if (takeRnd == "S")
        {
            TetrominoS();
        }else if (takeRnd == "Z")
        {
            TetrominoZ();
        }else if (takeRnd == "T")
        {
            TetrominoT();
        }else if (takeRnd == "O")
        {
            TetrominoO();
        }else if (takeRnd == "I")
        {
            TetrominoI();
        }else if (takeRnd == "L")
        {
            TetrominoL();
        }else if (takeRnd == "J")
        {
            TetrominoJ();
        }       

        GridDisplay.GridToShow();
        if (testSpawnBlock()) {
            GameOver();
        }else {
            GridDisplay.SetColors(Game.ShowTetris);
        }
    }
    private static void TetrominoJ() {
        Game.MirrorGrid[0][5] = SquareColor.GREEN;
        Game.MirrorGrid[1][5] = SquareColor.GREEN;
        Game.MirrorGrid[2][5] = SquareColor.GREEN;
        Game.MirrorGrid[2][4] = SquareColor.GREEN;
        Game.Color = SquareColor.GREEN;
        Game.xPiece = 5;
        Game.yPiece = 1;
    }
    private static void TetrominoL() {
        Game.MirrorGrid[0][4] = SquareColor.RED;
        Game.MirrorGrid[1][4] = SquareColor.RED;
        Game.MirrorGrid[2][4] = SquareColor.RED;
        Game.MirrorGrid[2][5] = SquareColor.RED;
        Game.Color = SquareColor.RED;
        Game.xPiece = 4;
        Game.yPiece = 1;
    }
    private static void TetrominoO() {
        Game.MirrorGrid[0][5] = SquareColor.PURPLE;
        Game.MirrorGrid[1][5] = SquareColor.PURPLE;
        Game.MirrorGrid[0][4] = SquareColor.PURPLE;
        Game.MirrorGrid[1][4] = SquareColor.PURPLE;
        Game.Color = SquareColor.PURPLE;


    }
    private static void TetrominoI() {
        Game.MirrorGrid[0][3] = SquareColor.ORANGE;
        Game.MirrorGrid[0][5] = SquareColor.ORANGE;
        Game.MirrorGrid[0][4] = SquareColor.ORANGE;
        Game.MirrorGrid[0][6] = SquareColor.ORANGE;
        Game.Color = SquareColor.ORANGE;

        Game.xPiece = 5;
        Game.yPiece = 0;
    }
    private static void TetrominoT() {
        Game.MirrorGrid[0][5] = SquareColor.YELLOW;
        Game.MirrorGrid[1][6] = SquareColor.YELLOW;
        Game.MirrorGrid[1][5] = SquareColor.YELLOW;
        Game.MirrorGrid[1][4] = SquareColor.YELLOW;
        Game.Color = SquareColor.YELLOW;

        Game.xPiece = 5;
        Game.yPiece = 1;
    }
    private static void TetrominoS() {
        Game.MirrorGrid[0][5] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[0][4] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[1][5] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[1][6] = SquareColor.DEEP_BLUE;
        Game.Color = SquareColor.DEEP_BLUE;

        Game.xPiece = 5;
        Game.yPiece = 1;
    }
    private static void TetrominoZ() {
        Game.MirrorGrid[0][5] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[0][6] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[1][5] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[1][4] = SquareColor.LIGHT_BLUE;
        Game.Color = SquareColor.LIGHT_BLUE;

        Game.xPiece = 5;
        Game.yPiece = 1;
    }



public static bool isFloorTouch(){
        int x;
        int y;
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!=SquareColor.TRANSPARENT){
                    x=j;
                    y=i;    
                    if(y==21 ||Game.Grid[y+1][x] != SquareColor.TRANSPARENT ){
                        Game.score += 10;
                        if (1-(Game.score/5000.0f) < 0.1f) 
                        {
                            GridDisplay.SetTickTime(0.1f);
                        }else {
                            GridDisplay.SetTickTime(1-(Game.score/5000.0f));
                        }
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public static void FloorTouch(){
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!=SquareColor.TRANSPARENT){
                    Game.Grid[i][j]=Game.MirrorGrid[i][j];
                }
            }
        }
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                Game.MirrorGrid[i][j]=SquareColor.TRANSPARENT;
            }
        }
        Board.SpawnPiece();
    }

    private static bool testSpawnBlock() {
        for (int i = 0; i < 22; i++)
        {
            for (int j = 0; j < 10; j++)
            {
              if (Game.MirrorGrid[i][j] != SquareColor.TRANSPARENT && Game.Grid[i][j] != SquareColor.TRANSPARENT) {
                return true;
              }  
            }
        }
        return false;
    }

    public static void IsGameOver(){
        for (int i = 0; i < 10; i++){
            if (Game.Grid[0][i]!= SquareColor.TRANSPARENT){
                GameOver();
            }
        }
    }

    private static void GameOver(){
        GridDisplay.GridToShow();
        GridDisplay.SetColors(Game.ShowTetris);
        Game.score = 0;
        GridDisplay.TriggerGameOver();
        Game.Gameover = true;
    }
}
