using System;
using System.Globalization;
using arquivo_7;

namespace ativ2POO{
class arquivo7{

    static void Main(string[]args){

    Produto p = new Produto();

     Console.WriteLine("---------ADICIONAR PRODUTO AO ESTOQUE------------- ");
     Console.Write("\n Nome: ");
     p.Nome = Console.ReadLine();

     Console.Write("\n Digite o Id do produto: ");
     p.Id = Console.ReadLine();

     Console.Write("\n Preço: ");
     p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

     Console.Write("\n Quantidade que voce irá adicionar: ");
     p.Quantidade = int.Parse(Console.ReadLine());

     Console.Write("\n Ano de lançamento: ");
     p.Ano = int.Parse(Console.ReadLine());

     Console.Write("\n Nome da editora: ");
     p.Editora = Console.ReadLine();

     Console.Write("\n Nome do escritor(a): ");
     p.Escritor = Console.ReadLine();

     Console.Write("\n Numero de paginas: ");
     p.Paginas = int.Parse(Console.ReadLine());

     Console.Write("\n Idioma: ");
     p.Idioma = Console.ReadLine();

     Console.Write("\n Idade indicada para leitura: ");
     p.IdadeInd = int.Parse(Console.ReadLine());

     Console.Write("\n Tipo da capa: ");
     p.TipoCapa = Console.ReadLine();

     Console.ReadLine();
     Console.Clear();

     Console.WriteLine("\n ----------------Dados do produto ---------------\n "+p);
    
     Console.ReadLine();
     Console.Clear();

     Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
     int qte = int.Parse(Console.ReadLine());

     p.AdicionarProdutos(qte);

     Console.ReadLine();
     Console.Clear();

     Console.WriteLine("\n ----------------Dados do produto atualizados ---------------\n "+p);

     Console.ReadLine();
     Console.Clear();

     Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
     qte = int.Parse(Console.ReadLine());
     p.RemoverProduto(qte);

     Console.ReadLine();
     Console.Clear();

     Console.WriteLine("\n ----------------Dados do produto atualizados.2 ---------------\n "+p);


    
     Console.ReadKey();
    }
} 
}
