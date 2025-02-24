package Senai_Exercicio;

public class EX_14 {
    public static void main(String[] args) {

        int num = 0, soma = 0;
        int [][] matriz = {
                {10,15,19},
                {55,400,79},
                {100,105,200}
        };

        for (int i = 0 ; i < matriz.length ; i++){
            for (int j = 0 ; j < matriz.length ; j++){
                if ( num == i && num == j){
                    soma  += matriz [i] [j];
                    num++;
                }
            }

        }
        System.out.printf(" O soma na diagoal na matriz e : %d  ",soma);
    }
}
