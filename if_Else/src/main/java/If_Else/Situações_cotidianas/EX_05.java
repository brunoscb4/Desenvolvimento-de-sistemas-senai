package If_Else.Situações_cotidianas;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        final String USUARIO_CORRETO = "admin";
        final String SENHA_CORRETA = "1234";

        System.out.print("Digite o usuário: ");
        String usuario = scanner.next();

        System.out.print("Digite a senha: ");
        String senha = scanner.next();

        if (usuario.equals(USUARIO_CORRETO) && senha.equals(SENHA_CORRETA)) {
            System.out.println("Login bem-sucedido! Acesso permitido.");
        } else {
            System.out.println("Usuário ou senha incorretos. Acesso negado.");
        }
    }
}
