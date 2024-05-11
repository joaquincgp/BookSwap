using BookSwap.Data;
using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Carrito
    {
       
        [Key]
        public int Id { get; set; }
        public List<ItemCarrito> ItemsCarritos { get; set; }

      



    }
}
