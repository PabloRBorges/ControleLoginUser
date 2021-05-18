using LoginUserControl.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginUserControl.Core.Entities
{
    public class Contrato : BaseEntity
    {
        public DateTime Validade { get; set; }
        public string ValorContrato { get; set; }
        public ICollection<Bomba> Bombas { get; set; }
        public ICollection<Placa> Placas { get; set; }
        public ICollection<Sensor> Sensores { get; set; }

    }
}
