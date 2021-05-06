using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUserControl.Contract.DTO
{
    public class BomdaDaguaModel
    {
        public Guid Id { get; set; }
        public string TipoBomba { get; set; }
        public List<Sensor> Sensores { get; set; }

    }
}
