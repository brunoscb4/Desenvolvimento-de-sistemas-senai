package Ex4;

public class menu {
    public static void main(String[] args) {
        Produto produto1 = new Produto("Notebook", 2500.0);
        produto1.exibirInformacoes();


        Produto produto2 = new Produto("Smartphone", -500.0);
        produto2.exibirInformacoes();
    }
}
