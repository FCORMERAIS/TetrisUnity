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
        Game.Grid[0][5] = SquareColor.GREEN;
        Game.Grid[1][5] = SquareColor.GREEN;
        Game.Grid[2][5] = SquareColor.GREEN;
        Game.Grid[2][4] = SquareColor.GREEN;
    }
    public static void TetrominoL() {
        Game.Grid[0][5] = SquareColor.RED;
        Game.Grid[1][5] = SquareColor.RED;
        Game.Grid[2][5] = SquareColor.RED;
        Game.Grid[2][6] = SquareColor.RED;
    }
    public static void TetrominoO() {
        Game.Grid[0][5] = SquareColor.PURPLE;
        Game.Grid[1][5] = SquareColor.PURPLE;
        Game.Grid[0][4] = SquareColor.PURPLE;
        Game.Grid[1][4] = SquareColor.PURPLE;
    }
    public static void TetrominoI() {
        Game.Grid[0][3] = SquareColor.ORANGE;
        Game.Grid[0][5] = SquareColor.ORANGE;
        Game.Grid[0][4] = SquareColor.ORANGE;
        Game.Grid[0][6] = SquareColor.ORANGE;
    }
    public static void TetrominoT() {
        Game.Grid[0][5] = SquareColor.YELLOW;
        Game.Grid[1][6] = SquareColor.YELLOW;
        Game.Grid[1][5] = SquareColor.YELLOW;
        Game.Grid[1][4] = SquareColor.YELLOW;
    }
    public static void TetrominoS() {
        Game.Grid[0][5] = SquareColor.DEEP_BLUE;
        Game.Grid[0][4] = SquareColor.DEEP_BLUE;
        Game.Grid[1][5] = SquareColor.DEEP_BLUE;
        Game.Grid[1][6] = SquareColor.DEEP_BLUE;
    }
    public static void TetrominoZ() {
        Game.Grid[0][5] = SquareColor.LIGHT_BLUE;
        Game.Grid[0][4] = SquareColor.LIGHT_BLUE;
        Game.Grid[1][5] = SquareColor.LIGHT_BLUE;
        Game.Grid[1][6] = SquareColor.LIGHT_BLUE;
    }


    public static bool isFloorTouch(){
        int x;
        int y;
        for (int i = 0;i<Game.MirrorGrid.Count;i++){
            for (int j =0;j<Game.MirrorGrid[0].Count;j++){
                if (Game.MirrorGrid[i][j]!=SquareColor.TRANSPARENT){
                    x=j;
                    y=i;
                    if(Game.Grid[y-1][x]!= SquareColor.TRANSPARENT){
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


    public static void TimeFunc(){
        Game.Grid[2][5] = SquareColor.RED;
        GridDisplay.SetColors(Game.Grid);


        // if (game.Score %5==0){
        //     GridDisplay.SetTickTime(time-(5%*time));
        // }
    }
}