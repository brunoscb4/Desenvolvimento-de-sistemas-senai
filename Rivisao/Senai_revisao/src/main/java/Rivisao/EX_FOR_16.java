package Rivisao;

import java.util.Scanner;

public class EX_FOR_16 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Informe uma palavra: ");
        String palavra = sc.next();

        for (int i = 0; i < palavra.length(); i++) {
            System.out.println(palavra.charAt(i));
        }
    }
}
