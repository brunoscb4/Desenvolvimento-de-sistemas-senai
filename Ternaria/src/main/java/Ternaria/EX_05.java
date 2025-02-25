package Ternaria;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um ano: ");
        int ano = sc.nextInt();
        String resultado = ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) ? "Bissexto" : "Não é bissexto";
        System.out.println(resultado);
        sc.close();
    }
}
