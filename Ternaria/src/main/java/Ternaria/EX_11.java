package Ternaria;

import java.util.Scanner;

public class EX_11 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um caractere: ");
        char c = sc.next().toLowerCase().charAt(0);
        String resultado = (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') ? "Vogal" : "Consoante";
        System.out.println(resultado);
        sc.close();
    }
}
