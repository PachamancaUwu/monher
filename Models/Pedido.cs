using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace monher.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? ClienteNombres { get; set; }
        public string? ClienteApellidos { get; set; }
        public string? EmpresaNombre { get; set; }
        public string? Ruc { get; set; }
        public string? Direccion { get; set; }
        public string? CodigoPostal { get; set; }
        public string? Celular { get; set; }
        public string? Correo { get; set; }
        public string? Notas { get; set; }
    }
}