package If_Else.Situações_cotidianas;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a temperatura em Celsius: ");
        double celsius = scanner.nextDouble();

        System.out.print("Converter para (F) Fahrenheit ou (K) Kelvin? ");
        char escolha = scanner.next().toUpperCase().charAt(0);

        if (escolha == 'F') {
            double fahrenheit = (celsius * 9/5) + 32;
            System.out.println("Temperatura em Fahrenheit: " + fahrenheit);
        } else if (escolha == 'K') {
            double kelvin = celsius + 273.15;
            System.out.println("Temperatura em Kelvin: " + kelvin);
        } else {
            System.out.println("Escolha inválida.");
        }
    }

}
