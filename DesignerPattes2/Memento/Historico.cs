using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.parte3
{
    public class Historico
    {
        private IList<EstadoContrato> EstadoContrato = new List<EstadoContrato>();

        public void Adiciona(EstadoContrato estado)
        {
            EstadoContrato.Add(estado);
        }
        public EstadoContrato Pega(int indice)
        {
            return EstadoContrato[indice];
        }
    }
}
