package Rivisao;

import java.util.Scanner;

public class EX_FOR_19 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int fatorial;
        int somaf=1;

        System.out.println("Informe um nuemro para saber o seu fatorial: ");
        fatorial=sc.nextInt();
        for (int i = 1; i <= fatorial ; i++) {
            somaf *= i;
        }
        System.out.printf("O fatorial do numero informado e de %d",somaf);
    }
}
