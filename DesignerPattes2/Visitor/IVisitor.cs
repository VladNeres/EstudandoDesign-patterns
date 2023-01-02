using DesignerPattes2.Cap4;
using DesignerPattes2.Enterpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.Visitor
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);

        void ImprimeSubtracao(Subtracao subtracao);

        void ImprimeNumero(Numero numero);

        void ImprimeMultiplicacao(Multiplicacao multiplicacao);

        void ImprimeDivisao(Divisao divisao); 
    }
}
