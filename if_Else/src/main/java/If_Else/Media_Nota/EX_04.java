package If_Else.Media_Nota;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a nota: ");
        double nota = scanner.nextDouble();

        if (nota >= 10) {
            System.out.println("Aluno aprovado com nota máxima!");
        } else {
            System.out.println("Aluno não atingiu a nota máxima.");
        }
    }
}
