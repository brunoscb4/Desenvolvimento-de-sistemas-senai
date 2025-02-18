package If_Else.Desafios_jogos;

import java.util.Scanner;

public class EX_03 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int numeroSecreto = 7;  // Defina o número secreto

        System.out.print("Tente adivinhar o número secreto (entre 1 e 10): ");
        int tentativa = scanner.nextInt();

        if (tentativa == numeroSecreto) {
            System.out.println("Parabéns! Você acertou.");
        } else {
            System.out.println("Você errou. O número secreto era " + numeroSecreto);
        }
    }
}
