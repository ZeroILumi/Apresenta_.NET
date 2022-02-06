using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_de_Apresentar_Console_App.Classes.NameSpace_Pilha
{
  //Criase um Classe Para Representar um Pilha 
    public class Pilha_Classe
    {
        // Um atributo do tipo objeto da classe Posição para ter os
        // atributos e metodos da Classe Posição
        Posicao primeiro;
        // Metodo de pilha Empilha que recebe um object que e
        // qualquer coisa para ele empilhar dentro do atributo primeiro
        public void Empilha(object item)
        {
            // Atributo primeiro se torna um objeto de posição com
            // seus valores atuais sendo seu valor antigo no começo "null" e
            // seu valor novo representado por "item" que depois sera se
            // valor antigo assim criando uma pilha de valores por essa reatribuição
            primeiro = new Posicao(primeiro, item);
        }
        // Metodo para desempilhar retorna o valor atual de
        // primeiro e torna seu valor o seu valor antigo que esta em proximo
        public object Desempilha()
        {
            // Se primeiro não tiver nada ou seja for nullo
            if(primeiro == null)
            {
                // Lançar nova Exception de operação invalida
                throw new InvalidOperationException("A Pilha esta vazia");
            }
            // A var genetica resultado e igual ao valor atual de primeiro que e "item"
            object resultado = primeiro.item;
            // primeiro se torna somente seu valor antigo ignorando "item"
            // que e seu valor atual assim tirando esse valor atual da pilha em primeiro
            // tornando seu valor antigo seu novo valor atual
            primeiro = primeiro.proximo;
            // returna o valor antigo
            return resultado;
        }
        // Classe Posição
        class Posicao
        {
            // Atributo de objeto de Posicao proximo
            public Posicao proximo;
            // Atributo do tipo object item
            public object item;
            // Metodo contrutor
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}