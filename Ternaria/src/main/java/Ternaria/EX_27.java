package Ternaria;

import java.util.Scanner;

public class EX_27 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite um número: ");
        int num = sc.nextInt();
        String resultado = (num >= 0) ? "Positivo ou Zero" : "Negativo";
        System.out.println(resultado);
        sc.close();
    }
}
