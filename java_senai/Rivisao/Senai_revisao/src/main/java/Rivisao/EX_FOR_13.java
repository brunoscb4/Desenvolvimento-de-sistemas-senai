package Rivisao;

public class EX_FOR_13 {
    public static void main(String[] args) {

                int n1 = 0, n2 = 1;
                System.out.println(n1);
                System.out.println(n2);

                for (int i = 3; i <= 10; i++) {
                    int nextTerm = n1 + n2;
                    System.out.println(nextTerm);
                    n1 = n2;
                    n2 = nextTerm;
                }


    }
}
