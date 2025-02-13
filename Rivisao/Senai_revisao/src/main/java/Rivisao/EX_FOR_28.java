package Rivisao;

public class EX_FOR_28 {
    public static void main(String[] args) {
        int[] numeros = {10,12,15,10,19};
        double media =0;

        for (int i = 0; i < numeros.length; i++) {
            media += numeros[i];
        }
        media = media/numeros.length;
        System.out.printf("A media e de: %.2f", media);
    }
}
