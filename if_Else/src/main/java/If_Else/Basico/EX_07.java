package If_Else.Basico;

import java.util.Scanner;

public class EX_07 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int numero = scanner.nextInt();

        if (numero % 5 == 0) {
            System.out.println("O número " + numero + " é múltiplo de 5.");
        } else {
            System.out.println("O número " + numero + " não é múltiplo de 5.");
        }

        scanner.close();
    }
}
