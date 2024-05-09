using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [MaxLength(100)]
        public string Descripcion { get; set; }

        [Required]
        public string Estado { get; set; }

        [Required]
        public string Idioma { get; set; }

        [Required, MaxLength(13)]
        public string ISBN { get; set; }

        [DisplayName("Fecha de publicacion"), DataType(DataType.Date)]
        public DateTime FechaPublicacion { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required, DataType(DataType.Currency)]
        public double Precio { get; set; }

        [Required]
        public string Autor {  get; set; }

        [DisplayName("Imagen")]
        public string ImageUrl { get; set; }
        

    }
}
