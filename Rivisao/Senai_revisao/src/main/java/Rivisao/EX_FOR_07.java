package Rivisao;

public class EX_FOR_07 {
    public static void main(String[] args) {
        int soma = 0;
        for (int i = 1; i <= 100 ; i++) {
            if (i%2==1){
                soma+=i;
            }
        }
        System.out.printf("A soma dos numeros imapres e de %d %n",soma);
    }
}
