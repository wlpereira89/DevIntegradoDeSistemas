using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public static class povoarBanco
    {
        public static void gerarCliente()
        {

            List<Object> nomes = povoarBanco.listarDeArq("nomes.csv");
            List<Object> sobrenomes = povoarBanco.listarDeArq("50sobren.csv");
            List<Object> cidade = povoarBanco.listarColunaDeArq(1, "cidades.csv");
            List<Object> estado = povoarBanco.listarColunaDeArq(2, "cidades.csv");
            List<Object> ruas = povoarBanco.listarDeArq("ruas.csv");
            foreach (var nome in nomes)
            {
                foreach (var sobrenome in sobrenomes)
                {
                    int pos = povoarBanco.numeroRd(0, 99);
                    pnClientes.novoCliente(nome + " " + sobrenome, ruas[povoarBanco.numeroRd(0, 99)].ToString(), cidade[pos].ToString(), estado[pos].ToString());
                }
            }

        }
        public static List<Object> listarDeArq(string arquivo)
        {
            String arq = AppDomain.CurrentDomain.BaseDirectory + arquivo;
            StreamReader listar = new StreamReader(arq);
            string linha = null;
            string[] linhaseparada = null;
            List<Object> linhas = new List<Object>();

            // ler o conteudo da linha e add na list 
            while ((linha = listar.ReadLine()) != null)
            {
                linhaseparada = linha.Split(';');
                foreach (var item in linhaseparada)
                {
                    linhas.Add(item);
                }
            }
            return linhas;
        }
        public static List<Object> listarColunaDeArq(int coluna, string arquivo)
        {
            String arq = AppDomain.CurrentDomain.BaseDirectory + arquivo;
            StreamReader listar = new StreamReader(arq);
            string linha = null;
            string[] linhaseparada = null;
            List<Object> linhas = new List<Object>();

            // ler o conteudo da linha e add na list 
            while ((linha = listar.ReadLine()) != null)
            {
                linhaseparada = linha.Split(';');
                int cont = coluna;
                foreach (var item in linhaseparada)
                {
                    if (cont%2!=0)
                        linhas.Add(item);
                    cont++;
                }
            }
            return linhas;
        }
        private static int numeroRd(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
