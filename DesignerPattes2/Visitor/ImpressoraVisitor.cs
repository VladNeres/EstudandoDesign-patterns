using DesignerPattes2.Cap4;
using DesignerPattes2.Enterpreter;
using DesignerPattes2.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.parte5
{
    public class ImpressoraVisitor :IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Esquerda.Aceita(this);
            Console.Write("+");
            soma.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtrai)
        {
            Console.Write("(");
            subtrai.Esquerda.Aceita(this);
            Console.Write("-");
            subtrai.Direita.Aceita(this);
            Console.Write(")");
        }  public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.Esquerda.Aceita(this);
            Console.Write("*");
            multiplicacao.Direita.Aceita(this);
            Console.Write(")");
        }  public void ImprimeDivisao(Divisao subtrai)
        {
            Console.Write("(");
            subtrai.Esquerda.Aceita(this);
            Console.Write("/");
            subtrai.Direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
