using System;

namespace LoginUserControl.Contract.DTO
{
    public class Sensor
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public DateTime DataFabricacao { get; set; }
        public string Fabricante { get; set; }
    }
}
