using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaCircularEstatica
{
    public class Fila
    {
        const int CAPACIDADE = 5; // capacidade máxima da fila
        private int quantidade = 0; // qtde de elementos enfileirados
        private int inicio = 0; // indica qual a primeira posição da fila
        private int fim = 0; // indica a próxima posição
        private string[] dados = new string[CAPACIDADE]; // armazenar os dados da fila
                                                         // retorna o tamanho da fila
        public int Tamanho()
        {
            return quantidade;
        }

        // enfileira um valor string
        public void Enfileirar(string p_valor)
        {
            if (Tamanho() == CAPACIDADE)
            {
                throw new Exception("A fila está cheia!!!!");
            }
            else
            {
                dados[fim] = p_valor;
                fim = (fim + 1) % CAPACIDADE;
                quantidade++;
            }
        }
        
        // remove o primeiro elemento da fila e devolve.
        public string Desenfileira()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                string valor = dados[inicio];
                inicio = (inicio + 1) % CAPACIDADE;
                quantidade--;
                return valor;
            }
        }

        // retorna o início da fila
        public string RetornaInicio()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                return dados[inicio];
            }
        }

        // retorna o final da fila
        public string RetornaFim()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                if (fim == 0)
                {
                    return dados[quantidade + 1];
                }
                else
                {
                    return dados[fim - 1];
                }
            }
        }

        // lista todos os elementos da lista
        public string Listar()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                var tempDados = new string[CAPACIDADE];
                var index = 0;
                while (Tamanho() > 0)
                {
                    tempDados[index] = Desenfileira();
                    index++;
                }
                dados = tempDados;
                inicio = 0;
                fim = (index) % CAPACIDADE;
                quantidade = index;
                return String.Join(",", dados);
            }
        }
    }
}
