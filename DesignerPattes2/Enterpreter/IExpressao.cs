using DesignerPattes2.parte5;
using DesignerPattes2.Visitor;

namespace DesignerPattes2.Cap4
{
    public interface IExpressao
    {
      public int Avalia();

        void Aceita(IVisitor impressora);
    }
}