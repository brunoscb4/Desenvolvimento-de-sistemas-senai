package Rivisao;

import java.util.Scanner;

public class EX_WHILE_43 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Informe um numero para somar seus digitos; ");
        String numero =  Integer.toString(sc.nextInt()) ;
        int soma = 0, cont = 0;
        do {
            soma += numero.charAt(cont) - '0';
            cont++;
        }while (numero.length() > cont) ;
        System.out.println(soma);
    }
}
