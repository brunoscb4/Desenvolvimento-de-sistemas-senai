package Rivisao;

import java.util.Scanner;

public class EX_FOR_17 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Informe uma palavra: ");
        String palavra = sc.next();

        for (int i = palavra.length() -1; i >=0  ; i--) {
            System.out.println(palavra.charAt(i));
        }
    }
}
