using BookSwap.Data;
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
        public string Id { get; set; }
        [Required]
        public List<ItemCarrito> itemCarritos { get; set; }

        public static Carrito GetCarrito(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<BookSwapContext>();
            string cartId = session.GetString("Id") ?? Guid.NewGuid().ToString();

            session.SetString("Id", cartId);

            return new Carrito(context) { Id = cartId };
        }


    }
}
