using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.cap6
{
    public class MensagemCliente:IMensagem
    {
        public IEnviador Enviador { get; set; }
        public string nome;
        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o cliente {0}", nome);
        }
    }
}
