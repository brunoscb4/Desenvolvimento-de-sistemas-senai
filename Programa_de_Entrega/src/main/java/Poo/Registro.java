package Poo;

import java.util.ArrayList;
import java.util.Random;

public class Registro extends ProductRegistration {

    Random random = new Random();
    private  int codigo = 1;
    private int cod;

    ArrayList<ProductRegistration> product;

    public Registro() {
        this.product = new ArrayList<>();
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public ArrayList<ProductRegistration> getProduct() {
        return product;
    }

    public void setProduct(ArrayList<ProductRegistration> product) {
        this.product = product;
    }

    @Override
    public void setCod(int cod) {
        this.cod = cod;
    }

    public void add (ProductRegistration products){
        products.setCod(codigo);
          product.add(products);
          codigo++;
          setCod(codigo);
    }

    public void search (){

        for (int i = 0; i < product.size(); i++) {
            if ( i == codigo-1){
                System.out.println("Nome : " + product.get(i).getNameItem());
                System.out.println("Quantidade : " + product.get(i).getQuantidade());
                System.out.printf("Valor : %.2f %n" , product.get(i).getValor());
                System.out.println("Codigo : " + product.get(i).getCod());
            }
        }
    }

    public void ProductStatus () {
        for (int i = 0; i < product.size(); i++) {
            if (i == cod -1) {
                System.out.println("Nome : " + product.get(i).getNameItem());
                System.out.println("Quantidade : " + product.get(i).getQuantidade());
                System.out.printf("Valor : %.2f %n", product.get(i).getValor());
                System.out.println("Codigo : " + product.get(i).getCod());
            }
        }

        for (Status s  : Status.values()){
            System.out.println(s + "-" + s.getDescricao());
        }
    }
}






