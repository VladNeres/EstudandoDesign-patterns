using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.cap6
{
    public interface IMensagem
    {
        public IEnviador Enviador { get; set; }
        void Envia();

        string Formata();
    }
}
