package If_Else.Financeiro;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o salário: R$ ");
        double salario = scanner.nextDouble();

        if (salario >= 3000) {
            System.out.println("Você pode financiar um imóvel.");
        } else {
            System.out.println("Salário insuficiente para financiamento.");
        }
    }
}
