package Senai_Exercicio;

public class EX_26 {
    public static void main(String[] args) {

        int [][] matriz = {
                {10,15,19},
                {55,68,79},
                {100,105,200}
        };

        for (int[] Matriz : matriz){
            for (int Matriz1 : Matriz ){
                System.out.print(Matriz1 +" ");
            }
            System.out.println(" ");
        }
    }
}
