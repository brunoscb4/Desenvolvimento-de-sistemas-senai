package If_Else.Matematica;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o primeiro número: ");
        int num1 = scanner.nextInt();

        System.out.print("Digite o segundo número: ");
        int num2 = scanner.nextInt();

        int diferenca = num1 - num2;

        if (diferenca < 0) {
            System.out.println("A diferença entre os números é negativa.");
        } else {
            System.out.println("A diferença entre os números não é negativa.");
        }
    }
}
