package Poo;

import java.util.Scanner;

public class Main_Class {
    public static void main(String[] args) {


        Scanner sc = new Scanner(System.in);
        Media media = new Media(0, 0);


        System.out.println("Informe a nota ");
        media.setNota(sc.nextDouble());
        System.out.println("Informe a nota ");
        media.setNota1(sc.nextDouble());

        System.out.println(media.MediaNota());


        Comparacao compara = new Comparacao();
        System.out.println("Informe a senha");
        compara.setSenha(sc.nextInt());

        System.out.println(compara.verificacao());


        Maior_100 maior = new Maior_100();
        for (int i = 0; i <= 1; i++) {
            System.out.printf("informe o %dº numero : ", i);
            maior.setNumero(maior.getVetor()[i] = sc.nextInt());
        }
        System.out.printf(maior.maior100());


        Usuario_senha usu = new Usuario_senha();
        System.out.println();
        System.out.println("informe o nome de usuario : ");
        usu.setUsuario(sc.next());
        System.out.println("Informe a sua senha : ");

        usu.setSenha(sc.next());

        System.out.printf(usu.verificacao());
        System.out.printf(usu.getUsuario() + "%n" + usu.getSenha());


        Saldo banco = new Saldo();
        System.out.println();
        System.out.println("------------------------------");
        System.out.printf("Saldo em conta : " + banco.getSaldo());
        System.out.println();
        System.out.printf("deseja sacar %n Informe um valor : ");
        banco.setSaque(sc.nextDouble());
        System.out.println(banco.saquelValor());
        System.out.println(banco.conta());

    }
}
