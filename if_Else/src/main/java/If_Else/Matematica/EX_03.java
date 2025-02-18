package If_Else.Matematica;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        int num1 = scanner.nextInt();

        System.out.print("Digite o segundo número: ");
        int num2 = scanner.nextInt();

        if (num1 % num2 == 0) {
            System.out.println("O primeiro número é divisível pelo segundo.");
        } else if (num2 % num1 == 0) {
            System.out.println("O segundo número é divisível pelo primeiro.");
        } else {
            System.out.println("Nenhum dos números é divisível pelo outro.");
        }
    }
}
