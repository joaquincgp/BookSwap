﻿using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class ItemCarrito
    {
        [Key]
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public int Cantidad { get; set; }

    }
}