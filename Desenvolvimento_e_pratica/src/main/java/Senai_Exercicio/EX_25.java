package Senai_Exercicio;

import java.util.Random;

public class EX_25 {
    public static void main(String[] args) {

        Random random = new Random();

        String [][] matriz  = {
                {"Bruno", "Igor","Renata"},
                {"Paulo","fernanda", "Raquel"},
                {"Tiago","Douglas","Gabriela"}

        };

        String[] palavras = {" - Ola "," - Bom dia "," - Boa tarde "," - Voce esta bem "," - Como vai? "};
        for (String [] Matriz : matriz){
            for (String Matriz1 : Matriz){


                    System.out.println(Matriz1 + palavras[random.nextInt(palavras.length)]);

            }
            System.out.println(" ");
        }

    }

}
