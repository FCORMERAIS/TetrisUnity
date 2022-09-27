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
    }
    public static void TetrominoJ() {
        Game.MirrorGrid[0][5] = SquareColor.GREEN;
        Game.MirrorGrid[1][5] = SquareColor.GREEN;
        Game.MirrorGrid[2][5] = SquareColor.GREEN;
        Game.MirrorGrid[2][4] = SquareColor.GREEN;
    }
    public static void TetrominoL() {
        Game.MirrorGrid[0][4] = SquareColor.RED;
        Game.MirrorGrid[1][4] = SquareColor.RED;
        Game.MirrorGrid[2][4] = SquareColor.RED;
        Game.MirrorGrid[2][5] = SquareColor.RED;
    }
    public static void TetrominoO() {
        Game.MirrorGrid[0][5] = SquareColor.PURPLE;
        Game.MirrorGrid[1][5] = SquareColor.PURPLE;
        Game.MirrorGrid[0][4] = SquareColor.PURPLE;
        Game.MirrorGrid[1][4] = SquareColor.PURPLE;
    }
    public static void TetrominoI() {
        Game.MirrorGrid[0][3] = SquareColor.ORANGE;
        Game.MirrorGrid[0][5] = SquareColor.ORANGE;
        Game.MirrorGrid[0][4] = SquareColor.ORANGE;
        Game.MirrorGrid[0][6] = SquareColor.ORANGE;
    }
    public static void TetrominoT() {
        Game.MirrorGrid[0][5] = SquareColor.YELLOW;
        Game.MirrorGrid[1][6] = SquareColor.YELLOW;
        Game.MirrorGrid[1][5] = SquareColor.YELLOW;
        Game.MirrorGrid[1][4] = SquareColor.YELLOW;
    }
    public static void TetrominoS() {
        Game.MirrorGrid[0][5] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[0][4] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[1][5] = SquareColor.DEEP_BLUE;
        Game.MirrorGrid[1][6] = SquareColor.DEEP_BLUE;
    }
    public static void TetrominoZ() {
        Game.MirrorGrid[0][5] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[0][6] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[1][5] = SquareColor.LIGHT_BLUE;
        Game.MirrorGrid[1][4] = SquareColor.LIGHT_BLUE;
    }


    public static bool isFloorTouch(){
        int x;
        int y;
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!=SquareColor.TRANSPARENT){
                    x=j;
                    y=i;
                    if(Game.Grid[y+1][x] != SquareColor.TRANSPARENT || y==20){
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
}