using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class Vehiculo
    {
        [Key]
        public required int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int Año { get; set; }
        public required string Color { get; set; }
        public required string TipoVehiculo { get; set; }
        public required int PropietarioId { get; set; } // este va a ser el enlace entre las entidades


        //Enlaces foraneos, de esta manera se representan las relaciones entre entidades
        [ForeignKey("PropietarioId")] //a la llave foranea se le pasa el atributo que es enlace 
        public Propietario Propietario{ get; set; }

        
    }
}