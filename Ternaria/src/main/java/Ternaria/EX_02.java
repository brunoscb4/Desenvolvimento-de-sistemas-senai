package Ternaria;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a idade: ");
        int idade = sc.nextInt();
        String resultado = (idade >= 18) ? "Maior de idade" : "Menor de idade";
        System.out.println("Classificação: " + resultado);
        sc.close();
    }
}
