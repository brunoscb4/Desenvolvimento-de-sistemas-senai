package Ex3;

public class ContaBancaria {
    private String titular;
    private double saldo;
    private String tipoConta;


    public ContaBancaria(String titular, double saldo, String tipoConta) {
        this.titular = titular;
        this.saldo = saldo;
        this.tipoConta = tipoConta;
    }


    public ContaBancaria(String titular) {
        this.titular = titular;
        this.saldo = 0.0;
        this.tipoConta = "Corrente";
    }

    public void exibirInformacoes() {
        System.out.println("Titular: " + titular + ", Saldo: " + saldo + ", Tipo de Conta: " + tipoConta);
    }
}
