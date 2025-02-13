package Rivisao;

import java.util.Scanner;

public class EX_WHILE_41 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("Informe uma palavra: ");
        String palavra = sc.next();
        int cont = 0;
        do {
            System.out.printf(palavra.charAt(cont)+" ");
            cont++;
        }while (cont < palavra.length());

    }
}
