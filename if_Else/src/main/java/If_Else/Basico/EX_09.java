package If_Else.Basico;

import java.util.Scanner;

public class EX_09 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int numero = scanner.nextInt();

        if (numero >= 10 && numero <= 50) {
            System.out.println("O número " + numero + " está dentro do intervalo de 10 a 50.");
        } else {
            System.out.println("O número " + numero + " está fora do intervalo de 10 a 50.");
        }

        scanner.close();
    }
}
