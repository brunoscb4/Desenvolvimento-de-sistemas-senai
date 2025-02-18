package If_Else.Financeiro;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o saldo da conta: R$ ");
        double saldo = scanner.nextDouble();

        System.out.print("Digite o valor do saque: R$ ");
        double saque = scanner.nextDouble();

        if (saque <= saldo) {
            System.out.println("Saque autorizado.");
        } else {
            System.out.println("Saldo insuficiente.");
        }
    }
}
