using DesignerPattes2.parte5;
using DesignerPattes2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.Cap4
{
    public class Subtracao : IExpressao
    {
        public IExpressao Direita { get; private set; }
        public IExpressao Esquerda { get; private set; }

        public Subtracao( IExpressao esquerda, IExpressao direita)
        {
            Direita = direita;
            Esquerda = esquerda;
        }

        public int Avalia()
        {
            int valorEsquerda = Esquerda.Avalia();
            int valorDireita = Direita.Avalia();
            return valorEsquerda - valorDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
