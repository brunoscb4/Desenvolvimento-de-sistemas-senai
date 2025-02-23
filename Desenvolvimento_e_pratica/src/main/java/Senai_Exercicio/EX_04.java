package Senai_Exercicio;

import java.util.Random;
import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Random random = new Random();

        int menor = 0;
        int maior = 0;

        int soma = 0;
        int [] vetor = new int[10];
        for ( int i = 0; i < vetor.length; i++) {

            vetor[i] = random.nextInt(1,100);

            System.out.printf(vetor[i]+" ");
            if (vetor[i] < menor || menor == 0){
                menor = vetor[i];
            }
            if (vetor[i] > maior){
                maior = vetor[i];
            }
        }

        System.out.printf("%n O menor numero   do vetor e %d%n: ", menor);

        System.out.printf("O maior numero   do vetor e %d%n: ", maior);

    }
}
