package Rivisao;

import javax.xml.transform.Source;
import java.util.Scanner;

public class EX_WHILE_39 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        int numero ;
        do {
            System.out.println("Informe um numero: ");
            numero = sc.nextInt();
            System.out.println( (numero >= 0? "Numero informado:"+numero: ""));
        }while (numero >= 0);
    }


}
