using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBTarjetaC.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }

        [Required]
        public string Titular { get; set; }
        public string NumeroTarjeta{ get; set; }

        public string FechaExpiracion { get; set; }

        public string CVV { get; set; }

    }
}
