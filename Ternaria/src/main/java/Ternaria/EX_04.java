package Ternaria;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num % 5 == 0) ? "Múltiplo de 5" : "Não é múltiplo de 5";
        System.out.println(resultado);
        sc.close();
    }
}
