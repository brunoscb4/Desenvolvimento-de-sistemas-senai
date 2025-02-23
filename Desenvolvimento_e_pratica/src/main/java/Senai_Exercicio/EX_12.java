package Senai_Exercicio;

import java.util.Scanner;

public class EX_12 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int [] [] matriz = new int[3] [3];
        int soma = 0;

        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
                System.out.printf("Informe um valor para matriz %d - %d : ", i + 1, j + 1);
                matriz [i] [j] = sc.nextInt();
            }

        }

        for (int [] Matriz :matriz){
            for (int Matriz1 : Matriz){
                soma += Matriz1;
            }
        }
        System.out.printf(" A soma e de : %d ",soma);
    }

}
