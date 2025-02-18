package If_Else.Desafios_jogos;

import java.util.Random;
import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Random random = new Random();
        int numeroSorteado = random.nextInt(10) + 1;  // Gera um número entre 1 e 10

        System.out.print("Tente adivinhar o número sorteado (entre 1 e 10): ");
        int tentativa = scanner.nextInt();

        if (tentativa == numeroSorteado) {
            System.out.println("Parabéns! Você acertou.");
        } else {
            System.out.println("Você errou. O número sorteado era " + numeroSorteado);
        }
    }
}
