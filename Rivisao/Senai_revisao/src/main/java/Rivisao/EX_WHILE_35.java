package Rivisao;

import java.util.Scanner;

public class EX_WHILE_35 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int cont =1;
        System.out.println("Informe um numero para ver a tabuada: ");
        int tabuada = sc.nextInt();

        do {
            System.out.printf(tabuada+"+"+cont+"="+(tabuada+cont)+" ");
            cont++;
        }while (cont<10);

    }
}
