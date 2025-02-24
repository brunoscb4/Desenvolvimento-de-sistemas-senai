package Senai_Exercicio;

import java.util.Arrays;
import java.util.Scanner;

public class EX_08 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        String [] vetorName = new String[5];

        for (int i = 0; i < vetorName.length; i++) {
            System.out.printf("Informe o %dº nome : ",i+1);
            vetorName[i] = sc.next();
        }

        Arrays.sort(vetorName);
        for (String name : vetorName){
            System.out.print( " " + name + " ");
        }
    }
}
