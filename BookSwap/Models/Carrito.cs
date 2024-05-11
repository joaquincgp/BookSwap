using BookSwap.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Carrito
    {

        private readonly BookSwapContext _context;

        public Carrito(BookSwapContext context)
        {
            _context = context;
        }

        [Key]
        public int Id { get; set; }
        public List<ItemCarrito> ItemsCarritos { get; set; }

        


    }
}
