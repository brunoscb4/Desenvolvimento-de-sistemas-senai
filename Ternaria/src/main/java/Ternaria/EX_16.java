package Ternaria;

import java.util.Scanner;

public class EX_16 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite true ou false: ");
        boolean valor = sc.nextBoolean();
        String resultado = valor ? "Sim" : "Não";
        System.out.println(resultado);
        sc.close();
    }
}
