package Poo;

public class Comparacao {
    private int senha;
    private int senhaSistema;

    public Comparacao (){
        this.senha = 0;
        this.senhaSistema = 1234;
    }

    public int getSenhaSistema() {
        return senhaSistema;
    }

    public int getSenha() {
        return senha;
    }

    public void setSenha(int senha) {
        this.senha = senha;
    }
     public String  verificacao(){
        if (senha == senhaSistema){
            return String.format("A senha digitada foi %d%n Esta correta ",senha);
        }else {
            return String.format("A senha digitada foi %d%n Esta incorreta ",senha);
        }
     }
}
