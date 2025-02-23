package Senai_Exercicio;

import java.util.Scanner;

public class EX_11 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int [][] matriz = new int [3][3];
        for (int i = 0; i < matriz.length; i++) {
            for (int j = 0; j < matriz.length; j++) {
            System.out.printf("Informe um valor matriz %d - %d  : ",i + 1,j + 1);
                matriz [i][j] = sc.nextInt();
            }

        }

        for (int [] Matriz : matriz){
            for (int Matriz1 : Matriz){
                System.out.printf("  %d ",Matriz1);
            }
            System.out.println( " ");
        }
    }
}
