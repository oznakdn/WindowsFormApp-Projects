using MyFarmYS.DAL.Repositories;
using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.BLL
{
    public class UremeBusiness : BaseCrudBusiness<Ureme>, IUremeRepo
    {
        public void DogurmaTarihiHesapla(Ureme ureme)
        {
            throw new NotImplementedException();
        }

        public short ServisPeriyoduHesapla(Ureme ureme)
        {
            throw new NotImplementedException();
        }
    }
}
