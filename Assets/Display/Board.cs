using System;
using System.Collections;
using System.Collections.Generic;
using Unity = UnityEngine;

public class Board{
    public static void SpawnPiece(List<List<SquareColor>> board){
        Random rnd = new Random();
        String[] Shape = {"S","Z","T","O","I","L","J"};
        int random = rnd.Next(0, Shape.Length);
        String takeRnd = Shape[random];
        if (takeRnd == "S")
        {
            TetrominoS(board);
        }else if (takeRnd == "Z")
        {
            TetrominoZ(board);
        }else if (takeRnd == "T")
        {
            TetrominoT(board);
        }else if (takeRnd == "O")
        {
            TetrominoO(board);
        }else if (takeRnd == "I")
        {
            TetrominoI(board);
        }else if (takeRnd == "L")
        {
            TetrominoL(board);
        }else if (takeRnd == "J")
        {
            TetrominoJ(board);
        }
    }
    public static void TetrominoJ(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.GREEN;
        board[1][5] = SquareColor.GREEN;
        board[2][5] = SquareColor.GREEN;
        board[2][4] = SquareColor.GREEN;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoL(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.RED;
        board[1][5] = SquareColor.RED;
        board[2][5] = SquareColor.RED;
        board[2][6] = SquareColor.RED;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoO(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.PURPLE;
        board[1][5] = SquareColor.PURPLE;
        board[0][4] = SquareColor.PURPLE;
        board[1][4] = SquareColor.PURPLE;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoI(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.ORANGE;
        board[1][5] = SquareColor.ORANGE;
        board[2][5] = SquareColor.ORANGE;
        board[3][5] = SquareColor.ORANGE;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoT(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.YELLOW;
        board[1][6] = SquareColor.YELLOW;
        board[1][5] = SquareColor.YELLOW;
        board[1][4] = SquareColor.YELLOW;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoS(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.DEEP_BLUE;
        board[0][4] = SquareColor.DEEP_BLUE;
        board[1][5] = SquareColor.DEEP_BLUE;
        board[1][6] = SquareColor.DEEP_BLUE;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
    public static void TetrominoZ(List<List<SquareColor>> board) {
        board[0][5] = SquareColor.LIGHT_BLUE;
        board[0][4] = SquareColor.LIGHT_BLUE;
        board[1][5] = SquareColor.LIGHT_BLUE;
        board[1][6] = SquareColor.LIGHT_BLUE;
        GridDisplay.SetColors(board);
        SpawnPiece(board);
    }
}