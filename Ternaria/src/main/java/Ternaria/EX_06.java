package Ternaria;

import java.util.Scanner;

public class EX_06 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a idade: ");
        int idade = sc.nextInt();
        System.out.print("Possui carteira de motorista? (true/false): ");
        boolean possuiCarteira = sc.nextBoolean();
        String resultado = (idade >= 18 && possuiCarteira) ? "Pode dirigir" : "Não pode dirigir";
        System.out.println(resultado);
        sc.close();
    }
}
