package Rivisao;



public class EX_WHILE_52 {
    public static void main(String[] args) {


        int num = 1, num1 = 2, cont = 0, vezes = 1;


        do {


            do {

                if (num1 % num == 0) {
                    cont++;
                }
                num++;

            } while (num <= num1);

            System.out.printf(cont == 2 ? num1 + " " : "");
            if (cont == 2){
                vezes++;
            }
            cont = 0;
            num1++;
            num = 1;

        }while (vezes <= 10);
    }
}



