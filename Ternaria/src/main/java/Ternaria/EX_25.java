package Ternaria;

import java.util.Scanner;

public class EX_25 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite o dia da semana: ");
        String dia = sc.next();
        String resultado = (dia.equalsIgnoreCase("sábado") || dia.equalsIgnoreCase("domingo"))
                ? "Final de semana" : "Dia útil";
        System.out.println(resultado);
        sc.close();
    }
}
