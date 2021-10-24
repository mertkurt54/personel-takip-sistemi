using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class IzinDAO : PersonelDataContext
    {
        public static void IzinEkle(IZIN iz)
        {
            try
            {
                db.IZIN.InsertOnSubmit(iz);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<IZINDURUM> DurumGetir()
        {
            return db.IZINDURUM.ToList();
        }

        public static List<IzinDetayDTO> IzinGetir()
        {
            List<IzinDetayDTO> liste = new List<IzinDetayDTO>();
            var list = (from i in db.IZIN
                        join p in db.PERSONEL on i.PersonelID equals p.ID
                        join d in db.IZINDURUM on i.IzinDurumID equals d.ID
                        select new
                        {
                            UserNo = p.UserNo,
                            ad = p.Ad,
                            soyad = p.Soyad,
                            durumad = d.IzinDurumAd,
                            durumID = i.IzinDurumID,
                            baslamaTarihi = i.IzinBaslamaTarih,
                            bitisTarihi = i.IzinBitisTarih,
                            personelID = i.PersonelID,
                            izinID = i.ID,
                            aciklama = i.Acıklama,
                            sure = i.Sure,
                            departmanID = p.DepartmanID,
                            pozisyonID=p.PozisyonID
                        }).OrderBy(x => x.baslamaTarihi).ToList();
            foreach (var item in list)
            {
                IzinDetayDTO dto = new IzinDetayDTO();
                dto.PersonelID = item.personelID;
                dto.BaslamaTarihi = item.baslamaTarihi;
                dto.UserNo = item.UserNo;
                dto.Ad = item.ad;
                dto.Soyad = item.soyad;
                dto.BitisTarihi = item.bitisTarihi;
                dto.Aciklama = item.aciklama;
                dto.IzinDurumAd = item.durumad;
                dto.IzinDurumID = item.durumID;
                dto.IzinID = item.izinID;
                dto.Sure = item.sure;
                dto.DepartmanID = item.departmanID;
                dto.PozisyonID = item.pozisyonID;
                liste.Add(dto);

            }
            return liste;
        }

        public static void IzinSil(int izinID)
        {
            try
            {
                IZIN iz = db.IZIN.First(x => x.ID == izinID);
                db.IZIN.DeleteOnSubmit(iz);
                db.SubmitChanges();

            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }

        public static void IzinGuncelle(int izinID, int onaylandı)
        {
            try
            {
                IZIN iz = db.IZIN.First(x => x.ID == izinID);
                iz.IzinDurumID = onaylandı;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static void IzinGuncelle(IzinDetayDTO detaydto)
        {
            try
            {
                IZIN iz = db.IZIN.First(x => x.ID == detaydto.IzinID);
                iz.Acıklama = detaydto.Aciklama;
                iz.IzinBaslamaTarih = detaydto.BaslamaTarihi;
                iz.IzinBitisTarih = detaydto.BitisTarihi;
                iz.Sure = detaydto.Sure;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
