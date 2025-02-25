package Ternaria;

import java.util.Scanner;

public class EX_24 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        int soma = 0;
        for (int i = 1; i < num; i++) {
            if (num % i == 0) {
                soma += i;
            }
        }
        String resultado = (soma == num) ? "Perfeito" : "Não perfeito";
        System.out.println(resultado);
        sc.close();
    }
}
