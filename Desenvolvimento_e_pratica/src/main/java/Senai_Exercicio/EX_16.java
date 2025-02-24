package Senai_Exercicio;

import java.util.Random;
import java.util.Scanner;

public class EX_16 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        Random random = new Random();

        System.out.printf("Informe o tamanho para a matriz %n");
        int num = sc.nextInt();
        int [] [] matriz = new int[num][num];

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                matriz[i][j] = random.nextInt(1,200);
                System.out.print(matriz[i][j] + " ");
            }
            System.out.println(" ");
        }
    }
}
