using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class PozisyonDetay
    {
        public int ID { get; set; }
        public int DepartmanID { get; set; }
        public int EskiDepartmanID { get; set; }
        public string PozisyonAd { get; set; }
       
    }
}
