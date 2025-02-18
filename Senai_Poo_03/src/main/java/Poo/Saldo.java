package Poo;

public class Saldo {
    public double saldo;
    public double saque;

    public Saldo() {
        this.saldo = 200;
        this.saque = 0;
    }

    public double getSaldo() {
        return saldo;
    }

    public void setSaldo(double saldo) {
        this.saldo = saldo;
    }

    public double getSaque() {
        return saque;
    }

    public void setSaque(double saque) {
        this.saque = saque;
    }


    public String conta() {

        if (saldo > 0) {
            return String.format("Seu saldo e de: %.2f  ", saldo);

        } else {
            return String.format("Seu saldo e de: %.2f %n Não a saldo em conta ", saldo);
        }
    }

    public String saquelValor(){

        if (saldo > 0 && saque <= saldo ){
            return String.format("Saque efetuado com sucesso ...%n " +
                    "Valor disponivel: " + (saldo = saldo-saque));
        }else {
            return "Valor indisponivel";
        }
    }
}
