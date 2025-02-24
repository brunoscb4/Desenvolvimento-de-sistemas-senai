package Senai_Exercicio;

public class EX_06 {

    public static void main(String[] args) {

        int [] vetor = {10,65,80,77,46,643,64,640,100,101};

        for (int i = 0; i < vetor.length; i++) {
            System.out.println((vetor[i] % 2) == 0 ? vetor[i] :"");
        }

    }
}
