package Ternaria;

import java.util.Scanner;

public class EX_09 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite o primeiro número: ");
        int num1 = sc.nextInt();
        System.out.print("Digite o segundo número: ");
        int num2 = sc.nextInt();
        String resultado = (num1 > num2) ? "Maior" : "Menor ou Igual";
        System.out.println(resultado);
        sc.close();
    }
}
