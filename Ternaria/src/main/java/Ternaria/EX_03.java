package Ternaria;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num > 0) ? "Positivo" : (num < 0) ? "Negativo" : "Zero";
        System.out.println("O número é: " + resultado);
        sc.close();
    }

}
