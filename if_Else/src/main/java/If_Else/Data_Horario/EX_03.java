package If_Else.Data_Horario;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o número do mês (1 a 12): ");
        int mes = scanner.nextInt();

        System.out.print("Digite o dia: ");
        int dia = scanner.nextInt();

        boolean valido = false;

        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12) {
            valido = dia >= 1 && dia <= 31;
        } else if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
            valido = dia >= 1 && dia <= 30;
        } else if (mes == 2) {
            valido = dia >= 1 && dia <= 28;
        }

        if (valido) {
            System.out.println("Data válida.");
        } else {
            System.out.println("Data inválida.");
        }
    }
}
