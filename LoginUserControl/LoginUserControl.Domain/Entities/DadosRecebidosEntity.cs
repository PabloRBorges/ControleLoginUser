using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginUserControl.Core.Entities
{
    public class DadoRecebido : BaseEntity
    {
        public Guid IdPlaca { get; set; }
        public DateTime DataUpdate { get; set; }
        public string DadosJson { get; set; }
    }
}

    