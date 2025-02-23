package Senai_Exercicio;

public class EX_29 {
    public static void main(String[] args) {


        int soma = 0;
        int [][] matriz = {
                {10,15,19},
                {55,68,79},
                {100,105,200},
                {19,55,88}
        };

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz ){
                soma += Matriz1;
            }

            System.out.printf(" A soma dos valores da soma da coluna e  de : %d %n",soma);
            soma = 0;
        }

    }
}
