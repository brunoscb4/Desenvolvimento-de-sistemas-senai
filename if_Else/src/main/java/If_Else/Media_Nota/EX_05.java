package If_Else.Media_Nota;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a nota da primeira disciplina: ");
        double nota1 = scanner.nextDouble();

        System.out.print("Digite a nota da segunda disciplina: ");
        double nota2 = scanner.nextDouble();

        if (nota1 >= 7 && nota2 >= 7) {
            System.out.println("Aluno aprovado em ambas as disciplinas!");
        } else {
            System.out.println("Aluno não foi aprovado em ambas as disciplinas.");
        }
    }
}
