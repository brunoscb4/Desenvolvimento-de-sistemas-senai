package Poo;

public class Media {

    private double nota;
    private double nota1;
    private double media ;

    public Media(double Nota,double Nota1) {
        this.nota = Nota;
        this.nota1 = Nota1;
        this.media = 0;

    }

    public double getNota1() {
        return nota1;
    }

    public void setNota1(double nota1) {
        this.nota1 = nota1;
    }

    public double getNota (){
        return nota;
    }
    public void setNota(double Nota){
        this.nota = Nota;
    }


    public String MediaNota(){
        media = (nota + nota1)/2;
       if (media >=7){
           return String.format("A sua media e de %.1f e foi aprovado",media);
        }else {
           return  String.format("A sua media e de %.1f e foi reprovado",media);
        }

    }


}
