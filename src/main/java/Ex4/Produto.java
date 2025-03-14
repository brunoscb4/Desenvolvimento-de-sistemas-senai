package Ex4;

public class Produto {
    private String nome;
    private double preco;


    public Produto(String nome, double preco) {
        this.nome = nome;
        this.preco = (preco < 0) ? 0.0 : preco;
    }

    public void exibirInformacoes() {
        System.out.println("Nome: " + nome + ", Preço: " + preco);
    }

}
