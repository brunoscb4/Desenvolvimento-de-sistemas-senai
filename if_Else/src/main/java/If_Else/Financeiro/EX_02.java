package If_Else.Financeiro;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o valor total da compra: R$ ");
        double valorCompra = scanner.nextDouble();

        if (valorCompra > 500) {
            double desconto = valorCompra * 0.10;
            double valorFinal = valorCompra - desconto;
            System.out.println("Desconto aplicado: R$ " + desconto);
            System.out.println("Valor final: R$ " + valorFinal);
        } else {
            System.out.println("Sem desconto. Valor final: R$ " + valorCompra);
        }
    }
}
