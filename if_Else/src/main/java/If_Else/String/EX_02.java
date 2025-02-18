package If_Else.String;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a senha: ");
        String senha = scanner.nextLine();

        if (senha.equals("1234")) {
            System.out.println("Senha correta!");
        } else {
            System.out.println("Senha incorreta!");
        }
    }
}
