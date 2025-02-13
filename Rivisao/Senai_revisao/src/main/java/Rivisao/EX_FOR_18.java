package Rivisao;

import java.util.Scanner;

public class EX_FOR_18 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("Informe uma palavra: ");
        String palavra = sc.next();
        boolean polindromo = true;
        for (int i = 0; i < palavra.length()/2; i++) {

            if (palavra.charAt(i) != palavra.charAt(palavra.length() -1)){
                polindromo =false;
                break;
            }
        }

        if (polindromo ){
            System.out.println("Esta palavra e uma palavra  palindromo..");
        }else {
        System.out.println("Esta palavra não e um polindromo..");
        }

    }
}
