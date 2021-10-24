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
    public class IsBLL
    {
        public static IsDTO GetAll()
        {
            IsDTO dto = new IsDTO();
            dto.Departmanlar = DepartmanDAO.DepartmanGetir();
            dto.Pozisyonlar = PozisyonDAO.PozisyonGetir();
            dto.Personeller = PersonelDAO.PerseonelGetir();
            dto.Durumlar = IsDAO.DurumGetir();
            dto.Isler = IsDAO.IsGetir();
            return dto;
        }

        public static void IsEkle(IS iss)
        {
            IsDAO.IsEkle(iss);
            
        }

        public static void isGuncelle(IsDetayDTO dto)
        {
            IsDAO.isGuncelle(dto);
        }

        public static void IsSil(int isID)
        {
            IsDAO.IsSil(isID);
        }

        public static void isGuncelle(int isID)
        {
            IsDAO.IsGuncelle(isID);
        }
    }
}
