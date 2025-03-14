package Ex3;

public class menu {
    public static void main(String[] args) {
        ContaBancaria conta1 = new ContaBancaria("Maria", 1500.0, "Poupança");
        conta1.exibirInformacoes();


        ContaBancaria conta2 = new ContaBancaria("Carlos");
        conta2.exibirInformacoes();
    }
}
