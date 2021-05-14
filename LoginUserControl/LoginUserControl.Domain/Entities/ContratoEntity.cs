using LoginUserControl.Core.Models;
using System;
using System.Collections.Generic;

namespace LoginUserControl.Core.Entities
{
    public class Contrato : BaseEntity
    {
        public DateTime Validade { get; set; }
        public string ValorContrato { get; set; }
        public List<Bomba> Bombas { get; set; }
        public List<Placa> Placas { get; set; }
        public List<Sensor> Sensores { get; set; }
        public TipoManutencao Manutencao { get; set; }
    }
}
