class Nodo {
    public int Valor { get; set; }
    public Nodo Prox { get; set; }

    public Nodo(int valor) {
        this.Valor = valor;
    }
}