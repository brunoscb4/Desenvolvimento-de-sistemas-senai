package Senai_Exercicio;

import java.util.Random;
import java.util.Scanner;

public class EX_18 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Random random = new Random();
        double soma = 0;


        int [] [] matriz = new int[4][4];

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                matriz[i][j] = random.nextInt(1,200);
                System.out.print(matriz[i][j] + " ");
                soma += matriz[i][j];
            }
            System.out.println(" ");
        }
        soma = soma / (matriz.length*4);
        System.out.printf(" A media da matriz e de : %.2f " , soma);
    }
}
