package If_Else.Situações_cotidianas;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        final int CODIGO_CORRETO = 12345;

        System.out.print("Digite o código de acesso: ");
        int codigo = scanner.nextInt();

        if (codigo == CODIGO_CORRETO) {
            System.out.println("Acesso permitido.");
        } else {
            System.out.println("Acesso negado.");
        }
    }
}
