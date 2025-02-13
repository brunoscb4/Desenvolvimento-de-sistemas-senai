package Rivisao;

import java.util.Scanner;

public class EX_FOR_09 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
            double div;
        System.out.println("Informe um numero para dsaber a tabuada: ");
            int numero = sc.nextInt();
            for (int i = 1; i <= 10; i++) {
                System.out.printf(numero+"x"+i+"="+(numero*i)+"%n");
            }
            System.out.println(" ");
            for (int i = 1; i <= 10; i++) {
                System.out.printf(numero+"-"+i+"="+(numero-i)+"%n");
            }
            System.out.println(" ");
            for (int i = 1; i <= 10; i++) {
                System.out.printf(numero+"+"+i+"="+(numero+i)+"%n");
            }
            System.out.println(" ");
            for (double i = 1; i <= 10; i++) {
             div = numero/i;
                System.out.printf(numero+"/"+i+"=%.2f %n",div);
            }

    }
}
