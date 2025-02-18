package If_Else.Basico;

import java.util.Scanner;

public class EX_08 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Digite um caractere: ");
        char caractere = scanner.next().toLowerCase().charAt(0);

        if (caractere == 'a' || caractere == 'e' || caractere == 'i' || caractere == 'o' || caractere == 'u') {
            System.out.println("O caractere '" + caractere + "' é uma vogal.");
        } else {
            System.out.println("O caractere '" + caractere + "' não é uma vogal.");
        }

        scanner.close();
    }
}
