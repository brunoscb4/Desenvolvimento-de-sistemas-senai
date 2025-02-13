package Rivisao;

import java.util.Scanner;

public class EX_WHILE_47 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Informe um numero para saber se ele e primo : ");
        int numero = sc.nextInt();
        int cont = 1, cont2 = 0;

        do {
            if (numero % 2 == 0){
                cont2++;
            }
            cont++;
        }while (cont < numero);
        System.out.println(cont2 <= 2? "Primo" : "Não e primo");
    }
}
