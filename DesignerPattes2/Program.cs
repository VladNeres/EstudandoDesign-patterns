
using DesignerPattes2.Adapter;
using DesignerPattes2.Cap4;
using DesignerPattes2.cap6;
using DesignerPattes2.cap7;
using DesignerPattes2.Capitulo1;
using DesignerPattes2.Enterpreter;
using DesignerPattes2.parte_2;
using DesignerPattes2.parte3;
using DesignerPattes2.parte5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace DesignerPattes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parte 1  Factory!
            /*IDbConnection conexao = new ConnectionFactory().GetConnection();
            IDbCommand comando = conexao.CreateCommand();
            comando.CommandText = "select * From tabela";*/


            //Flywight parte 2
            /*   NotasMusicais notas = new NotasMusicais();
              IList<INota> musicaQueEuQueroTocar=  new List<INota>()
              {
                   notas.Pega("do"),
                   notas.Pega("re"),
                   notas.Pega("mi"),
                   notas.Pega("fa"),
                   notas.Pega("fa"),
                   notas.Pega("fa"),
                   notas.Pega("do"),
                   notas.Pega("re"),
                   notas.Pega("do"),
                   notas.Pega("re"),
                   notas.Pega("re"),
                   notas.Pega("re"),
                   notas.Pega("do"),
                   notas.Pega("sol"),
                   notas.Pega("fa"),
                   notas.Pega("mi"),
                   notas.Pega("mi"),
                   notas.Pega("mi"),
                   notas.Pega("do"),
                   notas.Pega("re"),
                   notas.Pega("mi"),
                   notas.Pega("fa"),
              };

               Piano piano = new Piano();
               piano.Toca(musicaQueEuQueroTocar);
            */


            //MEMENTO;
            /*Historico historico = new Historico();

            Contrato contrato = new Contrato(DateTime.Now, "victor", TipoContrato.Novo);
            historico.Adiciona(contrato.SalvaEstado());


            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());
            
            contrato.Avanca();
            historico.Adiciona(contrato.SalvaEstado());

            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

            Console.ReadKey();*/

            //Interpreter
            //(1+10) (20-10) = 21
            /*IExpressao esquerda = new Multiplicacao(new Numero(1), new Numero(10));
             IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
             IExpressao soma  = new Multiplicacao(esquerda, direita);

             Console.WriteLine(soma.Avalia());*/

            //VISITOR
            /* IExpressao esquerda = new Soma(new Numero(1), new Numero(10));
             IExpressao direita = new Subtracao(new Numero(20), new Numero(10));
             IExpressao soma = new Soma(esquerda, direita);

             Console.WriteLine(soma.Avalia());
             ImpressoraVisitor impressora = new ImpressoraVisitor();
             soma.Aceita(impressora);*/


            //Bridge
            /*IMensagem mensagem = new MensagemCliente("Vlad");
            IEnviador enviador = new EnviaPorSMS();
            mensagem.Enviador = enviador;
            mensagem.Envia();*/


            //Command
            /*FilaDeTrabalho fila = new FilaDeTrabalho();
            Pedido pedido1 = new Pedido("Marcos", 100.0);
            Pedido pedido2 = new Pedido("Marinaldo", 200.0);

            fila.Adiciona(new PagaPedido(pedido1));
            fila.Adiciona(new PagaPedido(pedido2));

            fila.Adiciona(new FinalizaPedido(pedido1));

            fila.Processa();*/

            
            
            //ADAPTER
          /*  Cliente cliente= new Cliente();
            cliente.Nome = "Victor";
            cliente.Endereco = "Rua Vergueiro";
            cliente.DataDeNascimento= DateTime.Now;

            String xml = new GeradorDeXml().GeraXml(cliente);

            Console.WriteLine(xml);*/

        }
    }
}
