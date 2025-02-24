package Senai_Exercicio;



public class EX_19 {
    public static void main(String[] args) {

        int num = 0;
        int [][] matriz = {
                {10,11,12},
                {13,14,15},
                {16,17,18}
        };

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                if (num < 3){
                    System.out.print(matriz[i][num] + " ");
                }
            }
            num++;
            System.out.println(" ");

        }
    }
}
