package Ternaria;

import java.util.Scanner;

public class EX_21 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String parOuImpar = (num % 2 == 0) ? "Par" : "Ímpar";
        String posOuNeg = (num >= 0) ? "Positivo" : "Negativo";
        System.out.println(parOuImpar + " e " + posOuNeg);
        sc.close();
    }
}
