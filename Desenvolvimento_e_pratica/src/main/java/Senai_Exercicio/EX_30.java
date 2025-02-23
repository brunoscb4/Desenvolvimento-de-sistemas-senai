package Senai_Exercicio;

public class EX_30 {
    public static void main(String[] args) {


        int soma = 0;
        int [][] matriz = {
                {-10,15,19},
                {55,-68,79},
                {100,105,-200},
                {-19,55,88}
        };

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz ){
                if (Matriz1 < 0){
                    Matriz1 = 0;
                }
                System.out.print(Matriz1 + " ");
            }
            System.out.println(" ");
        }

    }

}
