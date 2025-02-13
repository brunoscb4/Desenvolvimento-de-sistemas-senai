package Rivisao;

public class EX_WHILE_55 {
    public static void main(String[] args) {

        int cont = 0, cont2 = 1;
        do {
            do {

                if (cont <= cont2){
                    System.out.print("5");
                    cont++;
                }

            }while (cont < cont2);
            System.out.println();
            cont2++;
            cont = 1;
        }while (cont2 <= 5);

    }
}
