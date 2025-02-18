package If_Else.Matematica;

import java.util.Scanner;

public class EX_05 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Digite um número: ");
        int num = scanner.nextInt();

        double raiz = Math.sqrt(num);

        if (raiz == (int) raiz) {
            System.out.println("O número é um quadrado perfeito.");
        } else {
            System.out.println("O número não é um quadrado perfeito.");
        }
    }
}
