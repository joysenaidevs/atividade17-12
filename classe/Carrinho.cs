using System.Collections.Generic;

namespace atividade17_12.classe
{
    public class Carrinho
    {
        //propiedade que guarda o valor total do carinho
        public float ValorTotal {get; set;}

        List<Produto> listaDeProduto = new List<Produto>();


        //metodo para adicionar produto no carrinho

        public void AdicionarProduto(Produto produto){
            listaDeProduto.Add(produto);
        }


    }
}