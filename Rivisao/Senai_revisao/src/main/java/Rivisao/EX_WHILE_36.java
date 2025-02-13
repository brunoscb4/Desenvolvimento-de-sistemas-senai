package Rivisao;

public class EX_WHILE_36 {
    public static void main(String[] args) {

        int cont = 1 , soma = 0;

        do {
            soma += cont;
            cont++;
        }while (cont != 50);
        System.out.printf("A soma e de: %d", soma);
    }

}
