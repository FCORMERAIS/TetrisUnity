using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class Game{
    public static List<List<SquareColor>> Grid = new List<List<SquareColor>>();
    public static List<List<SquareColor>> MirrorGrid = new List<List<SquareColor>>();
    public static List<List<SquareColor>> ShowTetris = new List<List<SquareColor>>();
    public static int score = 0;
    public static int xPiece = 0;
    public static int yPiece = 0;
    public static SquareColor Color;
    public static void tr(){
        Debug.Log(Game.xPiece);
        Debug.Log(Game.yPiece);
    }
}