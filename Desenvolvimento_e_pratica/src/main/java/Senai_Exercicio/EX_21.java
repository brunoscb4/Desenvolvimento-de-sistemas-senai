package Senai_Exercicio;

public class EX_21 {
    public static void main(String[] args) {

        int num = 0;
        int [][] matriz = {
                {10,11,12},
                {13,14,15},
                {16,17,18}
        };

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz){
                System.out.printf(" %d ",Matriz1);
            }
            System.out.println(" ");
        }

    }
}
