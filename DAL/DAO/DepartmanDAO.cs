using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmanDAO:PersonelDataContext
    {
         public static void DepartmanEkle(DEPARTMAN dpt)
        {
            try
            {
                db.DEPARTMAN.InsertOnSubmit(dpt);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<DEPARTMAN> DepartmanGetir()
        {
            try
            {
                return db.DEPARTMAN.ToList(); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DepartmanSil(int id)
        {
            try
            {
                DEPARTMAN dp = db.DEPARTMAN.First(x => x.ID == id);
                db.DEPARTMAN.DeleteOnSubmit(dp);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void DepartmanGuncelle(DEPARTMAN dpt)
        {
            try
            {
                DEPARTMAN dp = db.DEPARTMAN.First(x => x.ID == dpt.ID);
                dp.DepartmanAd = dpt.DepartmanAd;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
