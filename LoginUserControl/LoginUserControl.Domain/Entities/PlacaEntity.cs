using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginUserControl.Core.Entities
{
    public class Placa : BaseEntity
    {
        public string MacAdress { get; set; }
        public string Modelo { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string VersaoCodigo { get; set; }
        public bool EmUso { get; set; }
        public bool BloqueioContrato { get; set; }
    }
}