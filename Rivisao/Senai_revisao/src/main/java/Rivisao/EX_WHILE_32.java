package Rivisao;

import java.util.Scanner;

public class EX_WHILE_32 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int numero;
        int soma=0;
        do {
            System.out.println("Informe um numero: ");
            numero = sc.nextInt();

            soma+=numero;
        }while (numero!=0);
        System.out.printf("A soma dos numros informados e de %d",soma);
    }
}
