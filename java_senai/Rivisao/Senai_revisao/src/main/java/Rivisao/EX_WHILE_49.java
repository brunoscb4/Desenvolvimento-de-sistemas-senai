package Rivisao;
import java.util.Random;
public class EX_WHILE_49 {
    public static void main(String[] args) {


        Random random = new Random();
        String caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";
        String senha = "";

        int cont = 0;
        do {
            int indice = random.nextInt(caracteres.length());
            senha += caracteres.charAt(indice);
            cont++;
        } while (cont < 6);

        System.out.println("Senha gerada: " + senha);


    }
}
