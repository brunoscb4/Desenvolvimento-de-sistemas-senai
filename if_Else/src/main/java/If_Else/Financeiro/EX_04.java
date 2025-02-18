package If_Else.Financeiro;

import java.util.Scanner;

public class EX_04 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o salário: R$ ");
        double salario = scanner.nextDouble();

        System.out.print("Digite o valor da parcela: R$ ");
        double parcela = scanner.nextDouble();

        double limiteParcela = salario * 0.10;

        if (parcela <= limiteParcela) {
            System.out.println("Compra parcelada aprovada.");
        } else {
            System.out.println("Parcela acima do permitido.");
        }
    }
}
