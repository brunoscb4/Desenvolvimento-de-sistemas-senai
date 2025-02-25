package Ternaria;

import java.util.Scanner;

public class EX_07 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num > 0 && num % 2 == 0) ? "Sim" : "Não";
        System.out.println(resultado);
        sc.close();
    }
}
