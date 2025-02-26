package Poo;

public enum Status {

    PEDIDO_PROCESSADO ("Pedido recebido"),
    PROCESSANDO("Pedido em processamento"),
    ENVIADO("Pedido enviado"),
    ENTREGUE("Pedido entregue");

    private final String descricao;

    Status(String descricao) {
        this.descricao = descricao;
    }

    public String getDescricao() {
        return descricao;
    }
}
