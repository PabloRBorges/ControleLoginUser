namespace LoginUserControl.Core.Entities
{
    public class Sensor : BaseEntity
    {
        public string Modelo { get; set; }
        public string DataCompra { get; set; }
        public string Valor { get; set; }
        public string Vazao { get; set; }
        public bool EmUso { get; set; }
    }
}