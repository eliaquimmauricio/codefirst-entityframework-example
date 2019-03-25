using System.ComponentModel.DataAnnotations;

namespace Infra.Data.Models
{
    public class Devedores
    {
        [Key]
        public string Contrato { get; set; }

        public string Cpf { get; set; }

        public int? CodigoCliente { get; set; }

        public int? CodigoCarteira { get; set; }
    }
}
