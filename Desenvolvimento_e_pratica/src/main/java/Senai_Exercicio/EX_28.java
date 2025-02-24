package Senai_Exercicio;

public class EX_28 {
    public static void main(String[] args) {

        int maior = 0;
        int [][] matriz = {
                {10,15,19},
                {55,400,79},
                {100,105,200}
        };

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz ){
                if ( Matriz1 > maior){
                    maior = Matriz1;
                }
            }

        }
        System.out.printf(" O maior numero na matriz e : %d  ",maior);
    }
}
