package If_Else.Clasificações;

import java.util.Scanner;

public class EX_02 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite um número: ");
        int numero = scanner.nextInt();

        if (numero >= 1 && numero <= 10) {
            System.out.println("Classificação A");
        } else if (numero >= 11 && numero <= 20) {
            System.out.println("Classificação B");
        } else if (numero >= 21 && numero <= 30) {
            System.out.println("Classificação C");
        } else {
            System.out.println("Fora das classificações A, B e C");
        }
    }
}
