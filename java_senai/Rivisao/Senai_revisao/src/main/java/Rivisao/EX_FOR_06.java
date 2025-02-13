package Rivisao;

public class EX_FOR_06 {
    public static void main(String[] args) {
        int soma =0;
        for (int i = 1; i <= 100; i++) {
            if (i%2==0){
                soma +=i;
            }
        }
        System.out.printf("A soma dos numeros pares de 1 a 100 e de %d %n",soma);
    }
}
