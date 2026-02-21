using System.ComponentModel.DataAnnotations;

namespace RecetArreAPI2.Models
{
    public class Ingrediente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20, MinimumLength =3 )]
        public string Nombre { get; set; } = default!;
        [StringLength(20)]
        public string UnidadMed{ get; set; } = default!;
        [StringLength(30)]
        public string Descripcion { get; set; } = default!;
    }
}
