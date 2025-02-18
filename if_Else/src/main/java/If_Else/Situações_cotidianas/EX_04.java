package If_Else.Situações_cotidianas;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a idade: ");
        int idade = scanner.nextInt();

        System.out.print("Digite o peso (kg): ");
        double peso = scanner.nextDouble();

        if (idade >= 18 && idade <= 65 && peso >= 50) {
            System.out.println("Apto para doar sangue.");
        } else {
            System.out.println("Não está apto para doar sangue.");
        }
    }
}
