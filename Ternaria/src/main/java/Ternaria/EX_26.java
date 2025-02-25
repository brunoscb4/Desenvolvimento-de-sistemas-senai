package Ternaria;

import java.util.Scanner;

public class EX_26 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite sua idade: ");
        int idade = sc.nextInt();
        String resultado = (idade >= 16) ? "Pode votar" : "Não pode votar";
        System.out.println(resultado);
        sc.close();
    }
}
