package Rivisao;

import java.util.Scanner;

public class EX_FOR_22 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        double numero = sc.nextDouble();
        System.out.println("Os divisores do numero informado e: ");
        for (int i = 1; i <numero ; i++) {
            if (numero%i==0){
                System.out.printf(i+ " ");
            }

        }
    }
}
