package Senai_Exercicio;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);


        int soma = 0;
        int [] vetor = new int[6];
        for ( int i = 0; i < vetor.length; i++) {
            System.out.printf("Informe o %dº numero : ",i+1);
            vetor[i] = sc.nextInt();
            soma += vetor[i];

        }

        System.out.print("A media e de : "+ (soma / vetor.length));


    }

}
