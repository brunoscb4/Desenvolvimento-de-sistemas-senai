package Ternaria;

import java.util.Scanner;

public class EX_20 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a nota: ");
        double nota = sc.nextDouble();
        String resultado = (nota >= 7) ? "Aprovado" : (nota >= 5) ? "Recuperação" : "Reprovado";
        System.out.println(resultado);
        sc.close();
    }
}
