namespace Exercicio_Completo.Classes
{
    public class Produto : Carrinho
    {
        public int Codigo {get; set;}

        public string Nome {get; set;}

        public float Preco {get; set;}

        public Produto(int _codigo, string _nome, float _preco){

            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;

        }

        public Produto(int _codigo, string _nome, float _preco){
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }
    }
}