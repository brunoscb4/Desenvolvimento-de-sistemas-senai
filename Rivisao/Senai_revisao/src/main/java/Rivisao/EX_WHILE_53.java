package Rivisao;

public class EX_WHILE_53 {
    public static void main(String[] args) {

        int cont = 1, triangular = 0;

        do {
            triangular += cont;
            System.out.printf(" %d ",triangular);
            cont++;
        }while (cont <= 10);

    }
}
