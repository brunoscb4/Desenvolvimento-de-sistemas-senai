package Rivisao;

import java.util.Scanner;

public class EX_WHILE_45 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("Informe um numero para saber a sequencia de fibonacci: ");
        int numero = sc.nextInt();
        int soma = 0, soma1 = 1, soma3;

        if (numero >= 1) {
            System.out.print(", " + soma1);
        }

        do {
            soma3 = soma + soma1;

            if (soma3 > numero) break;

            System.out.print(", " + soma);

            soma = soma1;
            soma1 = soma3;
        } while (soma < numero);
    }
}
