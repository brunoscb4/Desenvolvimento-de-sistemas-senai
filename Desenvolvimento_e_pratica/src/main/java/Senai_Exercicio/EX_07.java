package Senai_Exercicio;

import java.util.Arrays;
import java.util.Scanner;

public class EX_07 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int [] vetor = new int[8];

        for (int i = 0; i < vetor.length; i++) {
            System.out.printf("Informe o %dº numero : ",i);
            vetor[i] = sc.nextInt();
        }
        Arrays.sort(vetor);

        for (int num : vetor){
            System.out.printf(" %d ",num);
        }
    }
}
