package If_Else.String;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite uma palavra: ");
        String palavra = scanner.nextLine();

        if (palavra.equals("Sim")) {
            System.out.println("Você respondeu Sim.");
        } else if (palavra.equals("Não")) {
            System.out.println("Você respondeu Não.");
        } else {
            System.out.println("Resposta inválida.");
        }
    }
}
