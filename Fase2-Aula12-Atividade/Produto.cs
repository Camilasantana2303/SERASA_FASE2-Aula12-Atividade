using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2_Aula12_Atividade
{
    internal class Produto
    {
        public string nome;
        public string descricao;
        public int quantidade;
        public double preco;
        public bool status;


        public void mostra()
        {
            Console.WriteLine($"Seu produto é {nome} ele é {descricao}, tem {quantidade}, o valor é {preco} e esta {status}");
        }

        public void desativa()
        {
            quantidade = 0;
            status= false; 
           
               
        }

        
        
    }
}
