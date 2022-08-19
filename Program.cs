using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
           User user = new User();
           user.setNome("Aninha");
           Console.WriteLine($"Nome do Usuário: {user.getNome()}");

           Produto produto = new Produto();
           produto.Nome = "Pera";
           produto.Preco = 4.5;
           

           Produto produto1 = new Produto
           {
               Nome = "Coca",
               Preco = 5   
           };
         Console.WriteLine($"Nome do Produto: {produto1.Preco}");
    
        }  
    }
}