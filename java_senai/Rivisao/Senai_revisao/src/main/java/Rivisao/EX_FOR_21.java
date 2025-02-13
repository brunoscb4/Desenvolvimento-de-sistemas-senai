package Rivisao;

import java.util.Scanner;

public class EX_FOR_21 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
    System.out.println("Informe um numero para saber a soma do seus digitos: ");
    int numero = sc.nextInt();
    int soma =0;

    String n = Integer.toString(numero);
        for (int i = 0; i <n.length() ; i++) {
            int valor = n.charAt(i)-'0';
            soma = soma + valor;

        }
        System.out.printf("A soma dos caracteres numericos e de: %d",soma);
    }
}
