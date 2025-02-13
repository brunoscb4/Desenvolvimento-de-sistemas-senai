package Rivisao;

public class EX_FOR_26 {
    public static void main(String[] args) {

        int base = 5;


        for (int i = 1; i <= base; i++) {
            for (int j = 1; j <= base - i; j++) {
                System.out.print(" ");
            }
            for (int j = 1; j <= i; j++) {
                System.out.print(j);
            }
            System.out.println();
        }
        for (int i = base - 1; i >= 1; i--) {
            for (int j = 1; j <= base - i; j++) {
                System.out.print(" ");
            }
            for (int j = 1; j <= i; j++) {
                System.out.print(j);
            }
            System.out.println();
        }



    }
}
