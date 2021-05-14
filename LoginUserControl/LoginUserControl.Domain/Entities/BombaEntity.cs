using System;

namespace LoginUserControl.Core.Entities
{
    public class Bomba : BaseEntity
    {

        public string Modelo { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string TipoTubo { get; set; }
        public string Diametro { get; set; }
        public string Vazao { get; set; }
    }
}