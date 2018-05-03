﻿using Modelo.PN;
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
        //[STAThread]
        private static pnFaturamento faturamento = null;

        public static pnFaturamento Faturamento { get => faturamento; set => faturamento = value; }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
       
    }
}
