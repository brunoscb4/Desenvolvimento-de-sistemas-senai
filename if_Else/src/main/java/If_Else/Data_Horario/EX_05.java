package If_Else.Data_Horario;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite o dia: ");
        int dia = scanner.nextInt();

        System.out.print("Digite o mês: ");
        int mes = scanner.nextInt();

        System.out.print("Digite o ano: ");
        int ano = scanner.nextInt();

        System.out.print("Digite o ano inicial do intervalo: ");
        int anoInicio = scanner.nextInt();

        System.out.print("Digite o ano final do intervalo: ");
        int anoFim = scanner.nextInt();

        if (ano >= anoInicio && ano <= anoFim) {
            System.out.println("A data está dentro do intervalo.");
        } else {
            System.out.println("A data está fora do intervalo.");
        }
    }
}
