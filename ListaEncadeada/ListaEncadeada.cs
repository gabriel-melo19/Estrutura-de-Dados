namespace Estrutura_de_Dados.ListaEncadeada {

    public class ListaEncadeada
    {
        private Nodo? primeiro;
        private int tamanho;


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
                return null!;
            }
            else
            {
                var atual = primeiro;
                for (index = 0; index <= tamanho; index++)
                {
                    if (atual is not null)
                    {
                        atual = atual.Prox;
                    }
                }
                return atual!;
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
                var anterior = Get(pos - 1);
                novoNodo.Prox = anterior.Prox;
                anterior.Prox = novoNodo;
            }

            tamanho++;
        }

        public void Imprimir() {
            var atual = primeiro;
            Console.Write("[");
            while (atual != null)
            {
                Console.Write(" " + atual.Valor + " ");
                atual = atual.Prox;
            }
            Console.Write("]");
            Console.WriteLine();
        }
    }
}