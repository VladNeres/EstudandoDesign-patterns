using DesignerPattes2.Capitulo1;
using DesignerPattes2.parte_2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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

            NotasMusicais notas = new NotasMusicais();
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
        }
    }
}
