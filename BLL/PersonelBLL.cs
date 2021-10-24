using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class PersonelBLL
    {
        public static PersonelDTO GetAll()
        {
            PersonelDTO dto = new PersonelDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.PerseonelGetir();
            return dto;
        }

        public static void PersonelEkle(PERSONEL pr)
        {
            PersonelDAO.PersonelEkle(pr);
        }

        public static bool isUnique(int v)
        {
            List<PERSONEL> list = PersonelDAO.PersonelGetir(v);
            if (list.Count > 0)
                return true;
            else
                return false;
        }

        public static List<PERSONEL> PersonelGetir(int v, string text)
        {
            return PersonelDAO.PerseonelGetir(v, text);
        }

        public static void PersonelGuncelle(PersonelDetayDTO pr)
        {
            PersonelDAO.PersonelGuncelle(pr);
        }

        public static void PersonelSil(int personelID)
        {
            PersonelDAO.PersonelSil(personelID);
        }
    }
}
