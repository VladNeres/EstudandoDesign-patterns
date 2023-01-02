using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattes2.cap6
{
    public class MensagemAdministrativa: IMensagem
    {
        public IEnviador Enviador { get; set; }
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            Enviador.Envia(this);

        }

        public string Formata()
        {
            return string.Format("Enviando a mensagem para o Administrador {0}", nome);
        }
    }
}
