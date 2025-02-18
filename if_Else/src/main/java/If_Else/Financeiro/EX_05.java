package If_Else.Financeiro;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o valor da compra: R$ ");
        double valorCompra = scanner.nextDouble();

        if (valorCompra >= 200) {
            System.out.println("Parabéns! Você ganhou um brinde.");
        } else {
            System.out.println("Compra abaixo do valor para ganhar brinde.");
        }
    }
}
