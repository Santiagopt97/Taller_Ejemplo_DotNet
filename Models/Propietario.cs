using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class Propietario
    {
        [Key]
        public required int Id { get; set; }

        [MinLength(5, ErrorMessage ="El campo nombre debe tener minimo {1} caracteres")]
        [MaxLength(100, ErrorMessage ="El campo nombre no puede tener mas de {1} caracteres")]
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string NumeroIdentificacion { get; set; }

        [Url]
        public required string FotoPerfil { get; set; }
        public required string Direccion { get; set; }

        [Phone(ErrorMessage ="Usa un formato valido para telefono")]
        [MinLength(7,ErrorMessage ="minimo 7 caracteres")]
        [MaxLength(15, ErrorMessage ="Maximo 15 caracteres")]
        public required string Telefono { get; set; }

        [EmailAddress(ErrorMessage ="Correo invalido")]
        [MinLength(5,ErrorMessage ="minimo 5 caracteres")]
        [MaxLength(255, ErrorMessage ="Maximo 255 caracteres")]
        public required string Correo { get; set; }
    }
}