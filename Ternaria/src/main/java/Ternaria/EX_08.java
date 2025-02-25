package Ternaria;

import java.util.Scanner;

public class EX_08 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a nota: ");
        double nota = sc.nextDouble();
        String resultado = (nota >= 7) ? "Aprovado" : "Reprovado";
        System.out.println(resultado);
        sc.close();
    }
}
