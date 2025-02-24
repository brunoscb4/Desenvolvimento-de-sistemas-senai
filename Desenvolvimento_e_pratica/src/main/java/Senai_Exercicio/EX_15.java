package Senai_Exercicio;

public class EX_15 {
    public static void main(String[] args) {


        int [][] matriz = {
                {10,15,19},
                {55,400,79},
                {100,105,200}
        };
        int num = 2, num1 = 0, soma = 0;
        for (int i = 0; i < matriz.length ; i++){
            for (int j = 0 ; j < matriz.length ; j++){
                if ( num1 == i  && num == j ){
                    soma  += matriz [i] [j];
                    System.out.println(matriz[i][j]);
                    num--;
                    num1++;
                }

            }

        }
        System.out.printf(" O soma na diagoal na matriz e : %d  ",soma);
    }
}
