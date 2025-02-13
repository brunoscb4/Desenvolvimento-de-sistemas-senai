package Rivisao;

import java.util.Scanner;

public class EX_WHILE_48 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int numero ;
        do {
            System.out.println("informe um numero para saber se e Impar ou Par : ");
            numero = sc.nextInt();

            System.out.println(numero % 2 == 0 ? "Par" : "Impar");

        }while (numero != 0);
    }
}
