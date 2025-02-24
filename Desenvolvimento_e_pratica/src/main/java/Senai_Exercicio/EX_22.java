package Senai_Exercicio;

public class EX_22 {public static void main(String[] args) {

    int soma  = 0;
    int [][] matriz = {
            {10,11,12},
            {13,14,15},
            {16,17,18}
    };

    for (int[] Matriz : matriz){
        for (int Matriz1 : Matriz){
            soma += Matriz1;
        }
        System.out.println(" ");
    }
    System.out.printf("A soma da matriz e de : %d",soma);
}
}
