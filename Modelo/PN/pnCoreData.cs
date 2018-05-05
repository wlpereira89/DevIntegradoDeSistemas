using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class pnCoreData
    {
        public static bool registrarVersao(int versao)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();

                
                CoreData core;
                core = new CoreData
                {
                    Vers = versao
                };

                db.CoreData.Add(core);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool faturar(DateTime inicio, DateTime fim)
        {
            try
            {
                GeFatEntities db = new GeFatEntities();


                if (db.CoreData.ToList().Count==0)
                {
                    registrarVersao(1);
                }
                int atual = db.CoreData.Max(core => core.Vers);
                CoreData coreAtual = db.CoreData.Find(atual);
                if (coreAtual.FatIni==null)
                {
                    coreAtual.FatIni = inicio;
                }
                else
                {
                    if (coreAtual.FatIni>inicio)
                    {
                        coreAtual.FatIni = inicio;
                    }
                }
                if (coreAtual.FatFim == null)
                {
                    coreAtual.FatFim = fim;
                }
                else
                {
                    if (coreAtual.FatFim < fim)
                    {
                        coreAtual.FatFim = fim;
                    }
                }
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<DateTime?>datasFaturadas()
        {
            try
            {
                GeFatEntities db = new GeFatEntities();

                int atual = db.CoreData.ToList().Max(c=>c.Vers);
                CoreData dadosAtutal = db.CoreData.Find(atual);
                List<DateTime?> datas = new List<DateTime?>();
                datas.Add(dadosAtutal.FatIni);
                datas.Add(dadosAtutal.FatFim);
                return datas;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
