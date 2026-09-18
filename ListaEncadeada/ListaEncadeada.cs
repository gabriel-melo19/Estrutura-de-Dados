class ListaEncadeada
{
    private Nodo primeiro;
    private int tamanho;

    public ListaEncadeada(Nodo primeiro, int tamanho)
    {
        this.primeiro = primeiro;
        this.tamanho = tamanho;
    }

    public int Size()
    {
        return tamanho;
    }

    public void Adicionar(int elemento)
    {
        var novoNodo = new Nodo(elemento);

        if (primeiro == null)
        {
            primeiro = novoNodo;
        }
        else
        {
            var atual = primeiro;
            while (atual.Prox != null)
            {
                atual = atual.Prox;
            }
            atual.Prox = novoNodo;
        }
        tamanho++;
    }

    public Nodo Get(int index)
    {
        if (index < 0 || index > tamanho)
        {
            return null;
        }
        else
        {
            var atual = primeiro;
            for (index = 0; index <= tamanho; index++)
            {
                atual = atual.Prox;
            }
            return atual;
        }
    }

    public void Adicionar(int pos, int elemento)
    {
        if (pos < 0 || pos > tamanho)
        {
            throw new IndexOutOfRangeException("Posição inválida!: " + pos);
        }

        if (pos == 1)
        {
            var novoNodo = new Nodo(elemento);
            novoNodo.Prox = primeiro;
            primeiro = novoNodo;
        }
        else
        {
            var novoNodo = new Nodo(elemento);
            // var anterior = novoNodo.Prox - 1;    // Erro: CS0019
            var atual = novoNodo;
        }

        tamanho++;
    }
}

