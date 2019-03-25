using System.ComponentModel.DataAnnotations;

namespace Infra.Data.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public double? PrecoUnitario { get; set; }

        public string Unidade { get; set; }

        public override string ToString()
        {
            return $"Id = {Id} Nome = {Nome} Categoria = {Categoria} PrecoUnitario = {PrecoUnitario}";
        }
    }
}
