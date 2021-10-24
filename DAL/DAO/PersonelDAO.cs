using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class PersonelDAO : PersonelDataContext
    {
        public static void PersonelEkle(PERSONEL pr)
        {
            try
            {
                db.PERSONEL.InsertOnSubmit(pr);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
          
        }

        public static List<PersonelDetayDTO> PerseonelGetir()
        {
            List<PersonelDetayDTO> liste = new List<PersonelDetayDTO>();
            var list = (from p in db.PERSONEL
                        join d in db.DEPARTMAN on p.DepartmanID equals d.ID
                        join pz in db.POZISYON on p.PozisyonID equals pz.ID
                        select new
                        {
                            personelID = p.ID,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            password = p.Password,
                            departman = d.DepartmanAd,
                            pozisyon = pz.PozisyonAd,
                            departmanID = d.ID,
                            pozisyonID = p.PozisyonID,
                            isAdmin = p.isAdmin,
                            maas = p.Maas,
                            resim = p.Resim,
                            dogumtarihi = p.DogumGunu,
                            adres = p.Adres,
                            UserNo = p.UserNo
                        }).OrderBy(x => x.personelID).ToList();
            foreach (var item in list)
            {
                PersonelDetayDTO dto = new PersonelDetayDTO();
                dto.PersonelID = item.personelID;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.password = item.password;
                dto.DepartmanAd = item.departman;
                dto.PozisyonAd = item.pozisyon;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                dto.isAdmin = item.isAdmin;
                dto.Maas = item.maas;
                dto.Resim = item.resim;
                dto.DogumTarihi = item.dogumtarihi;
                dto.Adres = item.adres;
                dto.UserNo = item.UserNo;
                liste.Add(dto);

            }
            return liste;
        }

        public static void PersonelSil(int personelID)
        {
            try
            {
                PERSONEL pr = db.PERSONEL.First(x => x.ID == personelID);
                db.PERSONEL.DeleteOnSubmit(pr);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void PersonelGuncelle(PozisyonDetay detay)
        {
            List<PERSONEL> list = db.PERSONEL.Where(x => x.PozisyonID == detay.ID).ToList();
            foreach (var item in list)
            {
                item.DepartmanID = detay.DepartmanID;
            }
            db.SubmitChanges();
        }

        public static void PersonelGuncelle(PersonelDetayDTO pr)
        {
            try
            {
                PERSONEL per = db.PERSONEL.First(x => x.ID == pr.PersonelID);
                per.UserNo = pr.UserNo;
                per.Ad = pr.Ad;
                per.Adres = pr.Adres;
                per.DepartmanID = pr.DepartmanID;
                per.DogumGunu = pr.DogumTarihi;
                per.isAdmin = pr.isAdmin;
                per.Maas = pr.Maas;
                per.Password = pr.password;
                per.PozisyonID = pr.PozisyonID;
                per.Resim = pr.Resim;
                per.Soyad = pr.Soyad;
                db.SubmitChanges();
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void PersonelMaasGuncelle(MaasDetayDTO maas)
        {
            try
            {
                PERSONEL pr = db.PERSONEL.First(x => x.ID == maas.PersonelID);
                pr.Maas = maas.MaasMiktar;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<PERSONEL> PerseonelGetir(int v, string text)
        {
            return db.PERSONEL.Where(x => x.UserNo == v && x.Password == text).ToList();
        }

        public static List<PERSONEL> PersonelGetir(int v)
        {
            return db.PERSONEL.Where(x => x.UserNo == v).ToList();

        }    
    }
}
