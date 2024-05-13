using IdentityModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookSwap.Models
{
    public class Cliente : IdentityUser
    {
        [Required]
        public string Nombre { get; set; }

        public string? Direccion { get; set; }
        public string? Ciudad { get; set; }
        public string? Provincia { get; set; }
        [Required, MaxLength(10)]
        public string? Celular { get; set; }
        [Required, MaxLength(10)]
        public string? Cedula { get; set; }

    }
     
}
