package Rivisao;

public class EX_FOR_30 {
    public static void main(String[] args) {
        int par=0,impar=0;
        int[] vetor = {10,44,11,1010,100,24,424,4,424,33,55,99,656,};

        for (int i = 0; i < vetor.length; i++) {
            if (vetor[i]%2==0){
                par +=1;
            }else {
                impar +=1;
            }

        }
        System.out.printf("Tem %d numeros pares %ne %d impares..",par,impar);
    }
}
