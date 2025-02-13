package Rivisao;

import java.util.Scanner;

public class EX_WHILE_54 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int numero;

        do {
            System.out.println("Informe um numero; ");
            numero = sc.nextInt();
            System.out.println(Math.sqrt(numero));

        }while (numero >= 0);
    }
}
