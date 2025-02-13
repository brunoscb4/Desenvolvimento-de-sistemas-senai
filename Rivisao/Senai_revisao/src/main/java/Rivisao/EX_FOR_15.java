package Rivisao;

public class EX_FOR_15 {
    public static void main(String[] args) {
        int num1=5,num2=3;
        for (int i = 1; i <= 100 ; i++) {
            if(i!=num1 && i!=num2) {
                System.out.println(i);
            }
             
                if (i == num1) {
                    System.out.println("Fizz");
                    num1 += 5;
                }
                if (i == num2) {
                    System.out.println("Buzz");
                    num2 += 3;
                }

        }
    }
}
