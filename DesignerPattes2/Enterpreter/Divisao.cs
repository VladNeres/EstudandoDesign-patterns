using DesignerPattes2.Cap4;
using DesignerPattes2.parte5;
using DesignerPattes2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.Enterpreter
{
    public class Divisao : IExpressao
    {
        public IExpressao Esquerda { get; private set; }
        public IExpressao Direita { get; private set; }

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            this.Esquerda = esquerda;
            this.Direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda / valorDireita;

        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeDivisao(this);
        }
    }
}
