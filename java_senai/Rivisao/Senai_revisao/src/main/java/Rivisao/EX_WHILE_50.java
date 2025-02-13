package Rivisao;


import java.util.Scanner;

public class EX_WHILE_50 {
    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        System.out.println("Informe uma senha : ");
        int senha1,senha = 1234;

        do {
            System.out.println("digite a senha: ");
            senha1 = sc.nextInt();


        }while (senha != senha1);
    }

}
