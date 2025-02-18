package If_Else.Basico;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite sua idade: ");
        int idade = scanner.nextInt();

        if (idade >= 16) {
            System.out.println("Você pode votar.");
        } else {
            System.out.println("Você não pode votar.");
        }

        scanner.close();
    }
}
