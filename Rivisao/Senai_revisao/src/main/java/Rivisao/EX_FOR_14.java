package Rivisao;

public class EX_FOR_14 {
    public static void main(String[] args) {


        System.out.println("Números primos entre 1 e 50:");


                for (int num = 2; num <= 50; num++) {
                    boolean isPrime = true;


                    for (int i = 2; i <= Math.sqrt(num); i++) {
                        if (num % i == 0) {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime) {
                        System.out.println(num);
                    }
                }



    }

}
