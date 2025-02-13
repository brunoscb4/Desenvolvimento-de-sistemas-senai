package Rivisao;

public class EX_FOR_08 {
    public static void main(String[] args) {
        double div = 0;
        for (int i = 1; i <= 10; i++) {
            System.out.printf("7x"+i+"="+(7*i)+"%n");
        }
        System.out.println(" ");
        for (int i = 1; i <= 10; i++) {
            System.out.printf("7-"+i+"="+(7-i)+"%n");
        }
        System.out.println(" ");
        for (int i = 1; i <= 10; i++) {
            System.out.printf("7+"+i+"="+(7+i)+"%n");
        }
        System.out.println(" ");
        for (double i = 1; i <= 10; i++) {
            div = (7/i);
            System.out.printf("7/"+i+"=%.2f %n",div);
        }
    }
}
