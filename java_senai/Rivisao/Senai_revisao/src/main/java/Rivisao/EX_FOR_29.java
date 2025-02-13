package Rivisao;

import java.util.Arrays;

public class EX_FOR_29 {
    public static void main(String[] args) {
        int[] numero = {60,45,20,12,69,80,18};


        for (int i = 0; i < numero.length -1; i++) {

            int minimo = i;
            for (int j = i+1; j < numero.length; j++) {
                if (numero[j]<numero[minimo]){
                    minimo=j;
                }
            }
            int temp = numero[minimo];
            numero[minimo] = numero[i];
            numero[i]=temp;
            System.out.println(numero[i]);
        }

    }
}
