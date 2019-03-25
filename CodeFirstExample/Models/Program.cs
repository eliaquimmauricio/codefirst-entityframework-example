using Infra.Data.Models;
using System;
using System.Linq;

namespace Infra.Data
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var contexto = new BancoDadosContext();

            //Salvar um devedor

            var produto = new Produto
            {
                Nome = "Harry Potter - Prisioneiro de Azkaban",
                Categoria = "Livro",
                PrecoUnitario = 30
            };

            contexto.Produtos.Add(produto);
            contexto.SaveChanges();

            //Usando transação

            produto = new Produto
            {
                Nome = "Harry Potter - Ordem da Fênix",
                Categoria = "Livro",
                PrecoUnitario = 32
            };

            var transacao = contexto.Database.BeginTransaction();

            contexto.Produtos.Add(produto);
            contexto.SaveChanges();

            transacao.Rollback(); // Ou transacao.Commit();

            //Obter Dados

            contexto.Produtos.ToList().ForEach(p => Console.WriteLine(p));

            //Atualizando um caso

            var produtosAtualizar = contexto.Produtos.First(a => a.PrecoUnitario == 30);
            produtosAtualizar.PrecoUnitario = 60;
            contexto.SaveChanges();

            //DeletandoCasos

            //var apagar = contexto.Produtos.First(p => p.Nome.Contains("Harry"));
            //contexto.Produtos.Remove(apagar);
            //contexto.SaveChanges();

            //Lista de entidades que são trabalhada

            foreach (var entry in contexto.ChangeTracker.Entries())
                Console.WriteLine(entry.State); // Estado de cada entidade

            Console.ReadKey();


        }
    }
}

/* ANOTAÇÕES SOBRE O CURSO:
  
Migrações são necessárias quando a estrutura das classes mudar e precisamos mudar no banco também.
  
Temos duas formas de fazer: Gerando o script SQL pelo Entity e executar no management ou deixar o proprio Entity fazer.
  
Os comandos disponiveis no migration são:
 
  Add-Migration
  Remove-Migration
  Update-Database    
  Script-Migration
  Drop-Database
  Scaffold-DbContext
 
Realizando um migration passo a passo.

1. Enable-Migrations
2. Add-Migration Inicial (Para criar a primeira versão, neste momento o código precisa estar igual ao banco)
3. Update-DataBase (Para aplicar o migration)
3. A partir daqui para cada alteração nos modelos, iremos ir criando um novo Migration e na sequencia update.

 */
