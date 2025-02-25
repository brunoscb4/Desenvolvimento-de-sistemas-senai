package Ternaria;

import java.util.Scanner;

public class EX_19 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num % 2 == 0 || num % 3 == 0) ? "Divisível" : "Não divisível";
        System.out.println(resultado);
        sc.close();
    }
}
