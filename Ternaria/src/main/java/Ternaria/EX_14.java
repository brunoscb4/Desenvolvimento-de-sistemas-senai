package Ternaria;

import java.util.Scanner;

public class EX_14 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num >= 10 && num <= 50) ? "Dentro do intervalo" : "Fora do intervalo";
        System.out.println(resultado);
        sc.close();
    }
}
