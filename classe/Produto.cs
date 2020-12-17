namespace atividade17_12.classe
{
    public class Produto
    {
        public int Codigo{ get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(){

        }

        public Produto(int codigo, string nome, float preco){
            this.Nome = nome;
            this.Codigo = codigo;
            this.Preco = preco;

        }


        
        
    }
}