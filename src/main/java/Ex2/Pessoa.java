package Ex2;

public class Pessoa {
    private String nome;
    private int idade;


    public Pessoa(String nome, int idade) {
        this.nome = nome;
        this.idade = idade;
    }

    public Pessoa() {
        this.nome = "Desconhecido";
        this.idade = 0;
    }

    public void exibirInformacoes() {
        System.out.println("Nome: " + nome + ", Idade: " + idade);
    }
}
