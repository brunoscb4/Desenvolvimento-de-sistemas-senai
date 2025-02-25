package Ternaria;

import java.util.Scanner;

public class EX_29 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite a idade: ");
        int idade = sc.nextInt();
        String resultado = (idade >= 18 && idade <= 60) ? "Adulto"
                : (idade > 60) ? "Idoso" : "Jovem";
        System.out.println(resultado);
        sc.close();
    }
}
