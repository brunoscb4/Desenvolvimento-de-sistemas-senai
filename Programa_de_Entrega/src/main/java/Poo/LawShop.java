package Poo;

import java.util.Random;
import java.util.Scanner;

public class LawShop {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        Random random = new Random();
        String com ;
        int num ;

        ProductRegistration p = new ProductRegistration();
        ProductRegistration p1 = new ProductRegistration();
        ProductRegistration p2 = new ProductRegistration();
        Registro r = new Registro();

        p.setNameItem("teclado");
        p.setQuantidade(10);
        p.setValor(130.30);
        r.add(p1);

            p1.setNameItem("Mouse");
            p1.setQuantidade(7);
            p1.setValor(80.30);
            r.add(p2);

                p2.setNameItem("Headset");
                p2.setQuantidade(12);
                p2.setValor(180.30);
                r.add(p);

                r.search();

      do {
          System.out.println("Informe a opção desejada");
          num = sc.nextInt();
          switch (num){
              case 1:
                  System.out.println("Digite o codigo do produto ..");
                  r.setCodigo(sc.nextInt());
                  r.search();
                  break;
              case 2:
                  System.out.println("Informe o codigo de rastreio..");
                  p.setCod(sc.nextInt());
                  r.ProductStatus();
                  r.setCod( p.getCod());
                  break;
          }


          System.out.println(" Deseja continuar : s/n");
          com = sc.next();
      }while (com.equals("s"));



    }
}
