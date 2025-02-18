package If_Else.String;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite uma palavra: ");
        String palavra = scanner.nextLine();

        if (palavra.length() > 5) {
            System.out.println("A palavra contém mais de 5 caracteres.");
        } else {
            System.out.println("A palavra não contém mais de 5 caracteres.");
        }
    }
}
