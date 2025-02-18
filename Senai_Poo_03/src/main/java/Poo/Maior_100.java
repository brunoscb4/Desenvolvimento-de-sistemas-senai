
package Poo;

public class Maior_100 {
    private int numero;
    private int soma;
    private int[] vetor = new int[2];


    public Maior_100 (){
        this.numero = 0;
        this.soma = 0;
        this.vetor = getVetor();
    }

    public int[] getVetor() {
        return vetor;
    }

    public void setVetor(int[] vetor) {
        this.vetor = vetor;
    }

    public int getNumero() {
        return numero;
    }

    public void setNumero(int numero) {
        this.numero = numero;
    }

    public int getSoma() {
        return soma;
    }

    public void setSoma(int soma) {
        this.soma = soma;
    }

    public String maior100(){
        for (int i = 0; i <= 1 ; i++) {
            soma += getVetor()[i];
        }
        if (soma > 100){
            return  String.format("A soma dos numeros e de %d%n ela e maior que 100",soma);
        }else {
            return  String.format("A soma dos numeros e de %d%n ela não e maior que 100",soma);
        }
    }
}
