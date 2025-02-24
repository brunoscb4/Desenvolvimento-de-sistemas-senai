package Senai_Exercicio;

public class EX_20 {
    public static void main(String[] args) {

        int soma = 0;
        int [][] matriz = {
                {10,11,12},
                {13,14,15},
                {16,17,18}
        };

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
               soma += matriz[i][j];
            }
            System.out.printf("A soma da coluna e de : %d  %n", soma);
            soma = 0;
        }
    }
}
