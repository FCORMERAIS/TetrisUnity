using System.Collections;
using System.Collections.Generic;
using System;
public class Clear {
        
        // Fonction qui permet de supprimer tous les éléments de la grille
        public static void ClearGrid(){
            List<List<SquareColor>> board = new List<List<SquareColor>>(); 
            for (int i=0;i<22;i++){
                List<SquareColor> Ligne = new List<SquareColor>();
                for (int j = 0;j<10;j++){   
                    Ligne.Add(SquareColor.TRANSPARENT);
                }
                board.Add(Ligne);
            }  
            GridDisplay.SetColors(board);
        }

        
        // Fonction qui permet de vérifier si une ligne est complète
        public static bool VerifyLineCompleted(){
            for(int i = 0; i < 22; i++){
                for(int j = 0; j < 10; j++){
                    if (GridDisplay.SetColors()[i][j] == completed){
                        return false;
                    }
                }
                return true;
            }
        
        }
        // Fonction qui permet de supprimer une ligne de la grille si elle est complète
        public static void ClearLine(){
            if (VerifyLineCompleted() == true){
                for(int i = 0; i < 22; i++){
                    for(int j = 0; j < 10; j++){
                        GridDisplay.SetColors(board)[i][j] = SquareColor.TRANSPARENT;
                    }
                }
            }   
        }

        // Fonction qui permet de calculer le score en fonction du nombre de ligne complétée
        public static void ShowScore(){
            int score = 0;
            for(int i = 0; i < x; i++){
                for(int j = 0; j < y; j++){
                    if(VerifyLineCompleted()){
                        score += 40;
                    }
                    if(VerifyLineCompleted()+ 1){
                        score += 100;
                    }
                    if (VerifyLineCompleted() + 2){
                        score += 300;
                    }
                    if (VerifyLineCompleted() + 3){
                        score += 1200;
                    }
                }
            }
            GridDisplay.SetScore(score);
        }
    }