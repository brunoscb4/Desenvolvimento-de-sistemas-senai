package If_Else.Situações_cotidianas;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o último número da placa do veículo: ");
        int ultimoNumeroPlaca = scanner.nextInt();

        if (ultimoNumeroPlaca % 2 == 0) {
            System.out.println("Veículo com placa de final PAR pode passar no pedágio.");
        } else {
            System.out.println("Veículo com placa de final ÍMPAR pode passar no pedágio.");
        }
    }
}
