package Rivisao;

public class EX_WHILE_37 {
    public static void main(String[] args) {
        int cont = 1;
        do {
            System.out.println( cont % 2 == 0? cont :"");

            cont++;
        }while (cont <= 20);
    }
}
