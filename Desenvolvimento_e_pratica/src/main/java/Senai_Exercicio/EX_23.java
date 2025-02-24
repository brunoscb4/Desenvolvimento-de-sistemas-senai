package Senai_Exercicio;

import java.util.Scanner;

public class EX_23 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int num = 0 , soma ;
        int [][] matriz = {
                {10,11,12},
                {13,14,15},
                {16,17,18}
        };

        System.out.println("Informe um numero para multiplicar na matriz : ");
        num = sc.nextInt();
        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz){
                soma = Matriz1 * num;
                System.out.print(soma + " ");
            }
            System.out.println(" ");
        }

    }
}
