package If_Else.Desafios_jogos;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        int num1 = scanner.nextInt();

        System.out.print("Digite o segundo número: ");
        int num2 = scanner.nextInt();

        if (num1 > 2 * num2) {
            System.out.println(num1 + " é maior que o dobro de " + num2);
        } else {
            System.out.println(num1 + " não é maior que o dobro de " + num2);
        }
    }
}
