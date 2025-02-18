package If_Else.Data_Horario;

import java.util.Scanner;

public class EX_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite a hora (0 a 23): ");
        int hora = scanner.nextInt();

        System.out.print("Digite os minutos (0 a 59): ");
        int minutos = scanner.nextInt();

        if (hora >= 0 && hora < 24 && minutos >= 0 && minutos < 60) {
            System.out.println("Horário válido.");
        } else {
            System.out.println("Horário inválido.");
        }
    }
}
