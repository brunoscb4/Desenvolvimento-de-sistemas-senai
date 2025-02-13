package Rivisao;

import java.util.Scanner;

public class EX_WHILE_40 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
           int cont = 0, numero;

            do {
                System.out.println("Informe um numero: ");
                numero = sc.nextInt();
               if (numero > 0){
                   cont++;
               }
            }while (numero > 0);

        System.out.printf("Foram informados %d numeros antes do 0 ", cont);

    }
}
