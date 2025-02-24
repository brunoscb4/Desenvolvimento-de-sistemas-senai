package Senai_Exercicio;

import java.util.Scanner;

public class EX_10 {
    public static void main(String[] args) {
        Scanner sc = new Scanner( System.in);
        int [] lista1 = new int[5];
        int [] lista2 = new int[5];
        int [] lista3 = new int[10];
        int cont = 0;

        for (int i = 0; i < lista1.length; i++) {
            System.out.printf("Informe o %dº numero da lista 1 : %n",i);
            lista1[i] = sc.nextInt();
            System.out.printf("Informe o %dº numero da lista 2 : %n",i);
            lista2[i] = sc.nextInt();
        }
        for (int i = 0; i < lista3.length; i++) {
            if (i >= lista1.length){
                lista3 [i] = lista2 [cont];
                cont++;
            }else {
                lista3[i] = lista1 [i];
            }
        }

        for (int i = 0; i < lista3.length; i++) {
            System.out.print(lista3[i] +" ");
        }
    }

}
