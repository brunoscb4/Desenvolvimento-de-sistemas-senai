package Senai_Exercicio;
import java.util.Random;

public class EX_24 {
    public static void main(String[] args) {

        Random random = new Random();

        int [][] matriz  = new int[10][10];
        for (int [] Matriz : matriz){
            for (int Matriz1 : Matriz){
                Matriz1 = random.nextInt(10,99);
                if (Matriz1 % 2 == 0){
                    System.out.printf(" %d ",Matriz1);
                }
            }
            System.out.println(" ");
        }

    }

}
