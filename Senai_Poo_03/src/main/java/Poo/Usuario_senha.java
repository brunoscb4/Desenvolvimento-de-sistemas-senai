package Poo;

public class Usuario_senha {
    private String usuario;
    private String senha;
    private final String senhaPadrao ;
    private final String usuarioPadrao ;

    public Usuario_senha(){
        this.usuario = "";
        this.senha = "";
        this.usuarioPadrao = "Senai@mg";
        this.senhaPadrao = "Senai123";
    }

    public String getUsuario() {
        return usuario;
    }

    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }

    public String getSenha() {
        return senha;
    }

    public void setSenha(String senha) {
        this.senha = senha;
    }


    public String verificacao (){
        if (usuarioPadrao.equals(usuario) && senhaPadrao.equals(senha)){
            return "Senha correta";
        }else {
            return "Senha incorreta";
        }
    }
}
