// // // Fonction pour affacer une ligne de la grille.
// using System;
// public class Clear {
    
//         public static void Clear(){
//             // si une forme touche le haut
//             if (isTop == true){
//                 board == SquareColor.TRANSPARENT;
//             }
//         }

//         // Si une ligne est complète
//         public static void ClearLine(){
//             for(int i = 0; i < 10; i++){
//                 for(int j = 0; j < 22; j++){
//                     GridDisplay.SetColor(i, j, SquareColor.TRANSPARENT);
//                 }
//             }
//         }

//         // Vérifie si une ligne est complète
//         public static void VerifyLineCompleted(){
//             if (int i = 0; i < 10; i++){
//                 if (GridDisplay.GetColor(i, j) == SquareColor.TRANSPARENT){
//                     ClearLine();
//                 }
//             }
//         }

//         public static void ShowScore(){
//             int score = 0;
//             for(int i = 0; i < x; i++){
//                 for(int j = 0; j < y; j++){
//                     if(VerifyLineCompleted()){
//                         score += 40;
//                     }
//                     if(VerifyLineCompleted()+ 1){
//                         score += 100;
//                     }
//                     if (VerifyLineCompleted() + 2){
//                         score += 300;
//                     }
//                     if (VerifyLineCompleted() + 3){
//                         score += 1200;
//                     }
//                 }
//             }
//             return score;
//         }
//     }