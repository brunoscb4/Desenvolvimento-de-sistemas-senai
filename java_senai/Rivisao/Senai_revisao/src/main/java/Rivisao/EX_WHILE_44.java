package Rivisao;

import java.util.Scanner;

public class EX_WHILE_44 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        System.out.println("Informe os numeros para saber seus divisores; ");
        int numero = sc.nextInt();
        int cont = 1;

        do {
            System.out.print(numero % cont == 0 ? cont +" " : "");
            cont++;
        }while (cont <= numero);
    }
}
