package Poo;

public class ProductRegistration {

        private String NameItem;
        private int quantidade;
        private double valor;
        private  int cod;

        public ProductRegistration() {
            NameItem = "product";
            this.quantidade = 0;
            this.valor = 0;
            this.cod = 0;
        }

        public String getNameItem() {
            return NameItem;
        }

        public void setNameItem(String nameItem) {
            NameItem = nameItem;
        }

        public int getQuantidade() {
            return quantidade;
        }

        public void setQuantidade(int quantidade) {
            this.quantidade = quantidade;
        }

        public double getValor() {
            return valor;
        }

        public void setValor(double valor) {
            this.valor = valor;
        }

        public int getCod() {
            return cod;
        }

        public void setCod(int cod) {
            this.cod = cod;
        }



}

