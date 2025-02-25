package Ternaria;

import java.util.Scanner;

public class EX_23 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite uma senha: ");
        String senha = sc.next();
        String resultado = (senha.length() >= 8) ? "Senha válida" : "Senha inválida";
        System.out.println(resultado);
        sc.close();
    }
}
