using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.Models
{
    public class Vehiculo
    {
        public required int Id { get; set; }
        public required string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int Año { get; set; }
        public required string Color { get; set; }
        public required string TipoVehiculo { get; set; }

        
    }
}