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
        public static bool gerarPedidos(int mes)
        {
            Pedidos p;
            DetalhesPedido produto;
            int nprod;
            Produtos prod;
            int atual;
            try
            {
                GeFatEntities db = new GeFatEntities();
                List<Produtos> prods = db.Produtos.ToList();
                List<Clientes> clis = db.Clientes.ToList();
                
                foreach (var cli in clis)
                { 
                    for (int pedPorCli = numeroRd(130, 170); pedPorCli > 0; pedPorCli--)
                    {
                        p = new Pedidos
                        {
                            Clientes = db.Clientes.Find(cli.ClienteID),                            
                            Data = new DateTime(2017, mes, numeroRd(1,28))                                
                        };
                        db.Pedidos.Add(p);
                        nprod = numeroRd(1, 19);
                        //List<int> num = ListaRd(1, prods.Count, nprod); 
                        while(nprod > 0)
                        {   
                            int num = numeroRd(1, prods.Count);
                            if (db.DetalhesPedido.Find(p.NroPedido, num) == null)
                            {
                                prod = db.Produtos.Find(num);
                                produto = new DetalhesPedido
                                {
                                    Pedidos = p,
                                    Produtos = prod,
                                    Qtde = numeroRd(1, 5),
                                    Preco = prod.Preco
                                };
                                nprod--;
                                db.DetalhesPedido.Add(produto);
                            }
                        }
                        db.SaveChanges();
                    }
                    
                }                      
                        

                return true;
            }
            catch (Exception)
            {
                throw;
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
        public static List<int> ListaRd(int min, int max, int tamanho)
        {
            List<int> lista= new List<int>();
            int rand;
            for (int i = 0; i < tamanho; i++)
            {
                rand = numeroRd(min, max);
                if (!lista.Contains(rand))
                {
                    lista.Add(rand);
                }
                else
                {
                    i--;
                }
                
            }
            return lista;
        }
    }
}
