using Modelo.PN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
       

        static void Main()
        {


            List<DateTime?> datas = pnCoreData.datasFaturadas();
            if ((datas[0]!=null)&&(datas[1]!=null))
                Global.Faturamento = new pnFaturamento((DateTime)datas[0], (DateTime)datas[1]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       
    }
    static class Global
    {
        private static pnFaturamento faturamento=null;

        

        public static pnFaturamento Faturamento { get => faturamento; set => faturamento = value; }
        
    }
    
}
