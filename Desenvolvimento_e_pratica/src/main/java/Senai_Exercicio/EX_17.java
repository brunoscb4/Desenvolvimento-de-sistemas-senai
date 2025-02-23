package Senai_Exercicio;

import java.util.Scanner;

public class EX_17 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);
        int num ;
        int [][] matriz = {
                {10,15,19},
                {55,400,79},
                {100,105,200}
        };
        System.out.println("Informe um numero : ");
        num = sc.nextInt();

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz ){
               Matriz1 *= num;
                System.out.printf(" %d ",Matriz1);
            }
            System.out.println(" ");
        }

    }
}
