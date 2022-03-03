using System.Globalization;
namespace arquivo_7{
    class Produto{
       public string Nome;
       public string Id;
       public double Preco;
       public int Quantidade;
       public int Ano;
       public string Escritor;
       public int Paginas;
       public string Idioma;
       public string Editora;
       public int IdadeInd;
       public string TipoCapa;



        public double ValorTotalEmEstoque(){

         return Preco * Quantidade;
     }

        public void RemoverProduto(int quantidade){

            Quantidade = Quantidade - quantidade;

        }

        public void AdicionarProdutos(int quantidade) {

            Quantidade = Quantidade + quantidade;

        }
        public override string ToString(){


            return "\n\n ID: " +Id
            + "\n Nome do livro:" + Nome
            + "\n\n Nome do Escritor: " + Escritor
            + "\n\n Editora: " + Editora
            + "\n\n Ano de lançamento: " + Ano
            + "\n\n Tipo de capa: " +TipoCapa
            + "\n\n Idioma: " +Idioma
            + "\n\n Idade indicada para leitura: " +IdadeInd
            + "\n\n Quantidade de paginas: " +Paginas
            + "\n\n Preço: $" + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + "\n\n Quantidade adicionada: " + Quantidade 
            + " unidades\n\n Estimativa de lucro: $" + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
