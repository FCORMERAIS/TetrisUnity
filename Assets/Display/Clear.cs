// // Fonction pour affacer une ligne de la grille.
using System;
public class Clear {
    
        public static void Clear(){

        }
        public static void ClearLine(){
            for(int i = 0; i < x; i++){
                for(int j = 0; j < y; j++){
                    GridDisplay.SetColor(i, j, SquareColor.GREEN);
                }
            }
        }

        public static void VerifyLineCompleted(){
            for(int i = 0; i < x; i++){
                for(int j = 0; j < y; j++){
                    if(GridDisplay.GetColor(i, j) == SquareColor.GREEN){
                        return false;
                    }
                }
            }
            return true;
        }

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
            return score;
        }
    }