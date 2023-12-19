using MyFarmYS.DAL.Repositories;
using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.BLL
{
    public class LaktasyonBusiness : BaseCrudBusiness<Laktasyon>, ILaktasyonRepo
    {
        public short LaktasyonSuresiHesapla(Laktasyon laktasyon)
        {
            throw new NotImplementedException();
        }

        public short LaktasyonSutVerimHesapla(Laktasyon laktasyon)
        {
            throw new NotImplementedException();
        }
    }
}
