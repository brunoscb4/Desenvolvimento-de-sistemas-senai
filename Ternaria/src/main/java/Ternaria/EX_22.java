package Ternaria;

import java.util.Scanner;

public class EX_22 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.print("Digite o valor do produto: ");
        double valorProduto = sc.nextDouble();
        String resultado = (valorProduto >= 100) ? "Frete grátis" : "Sem frete grátis";
        System.out.println(resultado);
        sc.close();
    }
}
