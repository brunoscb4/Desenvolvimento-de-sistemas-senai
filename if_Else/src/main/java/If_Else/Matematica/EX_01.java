package If_Else.Matematica;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        int num1 = scanner.nextInt();

        System.out.print("Digite o segundo número: ");
        int num2 = scanner.nextInt();

        int soma = num1 + num2;

        if (soma > 100) {
            System.out.println("A soma dos números é maior que 100.");
        } else {
            System.out.println("A soma dos números não é maior que 100.");
        }
    }
}
