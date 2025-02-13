package Rivisao;

import java.util.Scanner;

public class EX_WHILE_31 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int numero =0;
        do {
            System.out.println("Informe um numero:");
            System.out.println("Se ele for negativo o programa se encerra..");
            numero = sc.nextInt();
        }while (numero>0);
    }
}
