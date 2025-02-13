package Rivisao;

public class EX_FOR_27 {
    public static void main(String[] args) {
        int [] soma ={1,5,10,80,41};
        int soma1=0;

        for (int i = 0; i < soma.length; i++) {
            soma1 += soma[i];
        }
        System.out.printf("A soma do valor do vector e de: %d",soma1);
    }
}
