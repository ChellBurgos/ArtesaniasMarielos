using System.ComponentModel.DataAnnotations;

namespace Artesanias_Marielos.Entities
{
    public class Categorias
    {
        [Key]
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public bool Estado { get; set; }
    }
}
