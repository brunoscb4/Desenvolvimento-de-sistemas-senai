package If_Else.Clasificações;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a pressão sistólica (ex: 120): ");
        int sistolica = scanner.nextInt();

        System.out.print("Digite a pressão diastólica (ex: 80): ");
        int diastolica = scanner.nextInt();

        if (sistolica < 120 && diastolica < 80) {
            System.out.println("Pressão normal");
        } else if (sistolica <= 139 || diastolica <= 89) {
            System.out.println("Pressão moderada (pré-hipertensão)");
        } else {
            System.out.println("Pressão alta (hipertensão)");
        }
    }
}
