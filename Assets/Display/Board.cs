using System;
using System.Collections;
using System.Collections.Generic;
using U = UnityEngine;
using System.Threading;


public class Board{
    public static void SpawnPiece(List<List<SquareColor>> board){
        String[] Shape = {"I","L","J","O","S","T","Z"};
        Random rnd = new Random();
        int random = rnd.Next(0, Shape.Length);
    }
    public static void FloorTouch(List<List<SquareColor>> board){
        for (int i = 0;i<board.Count;i++){


        }
    

        Board.SpawnPiece(board);
    }
    public static void TimeFunc(){
        // for (int i=0;i<22;i++){
        //     for (int j = 0;j<10;j++){

        //     }
        //     board.Add(Ligne);
        // }
        // U.Debug.Log("uwu");
        
        Game.Grid[2][5] = SquareColor.RED;
        GridDisplay.SetColors(Game.Grid);
        // for (int i = 0;i<Game.Grid.Count;i++){
        //     for (int j = 0;j<Game.Grid[0].Count;j++){
                

        //     }
        // }

        // if (game.Score %5==0){
        //     GridDisplay.SetTickTime(time-(5%*time));
        // }
    }

}