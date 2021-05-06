using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUserControl.Contract.DTO
{
    public class MedidorVazaoModel
    {
        public Guid Id { get; set; }
        public DateTime DataFrabricacao { get; set; }
        public string Fabricante { get; set; }
        public List<Sensor> Sensores { get; set; }
        public string PrecoTotal { get; set; }
        public bool EmUtilizacao { get; set; }
    }

   
}
