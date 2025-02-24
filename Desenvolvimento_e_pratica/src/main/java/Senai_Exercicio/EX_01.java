package Senai_Exercicio;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int i ;
        int [] vetor = new int[5];
        for ( i = 0; i < vetor.length; i++) {
            System.out.printf("Informe o %dº numero : ",i+1);
            vetor[i] = sc.nextInt();


        }
        for (int j = 0; j < vetor.length; j++) {
            System.out.println(vetor[j]);
        }

    }

}
