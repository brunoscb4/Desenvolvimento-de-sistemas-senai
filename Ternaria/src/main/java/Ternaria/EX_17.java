package Ternaria;

import java.util.Scanner;

public class EX_17 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a idade: ");
        int idade = sc.nextInt();

        System.out.print("É estudante? (true/false): ");
        boolean estudante = sc.nextBoolean();
        String resultado = (idade > 60 || estudante) ? "Desconto aplicado" : "Sem desconto";
        System.out.println(resultado);
        sc.close();
    }
}
