package Senai_Exercicio;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int num;
        boolean verica =false ;
        int [] vetor = new int[5];

        vetor[0] = 10;
        vetor[1] = 15;
        vetor[2] = 26;
        vetor[3] = 59;
        vetor[4] = 120;

        System.out.println("Informe um numero para buscar no vetor :");
        num = sc.nextInt();
        for (int i = 0; i < vetor.length; i++) {
            if (vetor[i] == num){
                verica = true;
                break;
            }

        }
        if (verica){
            System.out.printf("Numero encontrado : %d",num);
        }else {
            System.out.printf("Numero não encontrado %d",num);
        }
    }


}
