package Ternaria;

import java.util.Scanner;

public class EX_18 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite os três lados do triângulo: ");
        int a = sc.nextInt(), b = sc.nextInt(), c = sc.nextInt();
        String tipo = (a == b && b == c) ? "Equilátero" : (a == b || a == c || b == c) ? "Isósceles" : "Escaleno";
        System.out.println("Tipo: " + tipo);
        sc.close();
    }
}
