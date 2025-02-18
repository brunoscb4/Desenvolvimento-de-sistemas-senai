package If_Else.Media_Nota;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a primeira nota: ");
        double nota1 = scanner.nextDouble();

        System.out.print("Digite a segunda nota: ");
        double nota2 = scanner.nextDouble();

        System.out.print("Digite a terceira nota: ");
        double nota3 = scanner.nextDouble();

        double maiorNota = Math.max(nota1, Math.max(nota2, nota3));
        double menorNota = Math.min(nota1, Math.min(nota2, nota3));

        System.out.println("Maior nota: " + maiorNota);
        System.out.println("Menor nota: " + menorNota);
    }

}
