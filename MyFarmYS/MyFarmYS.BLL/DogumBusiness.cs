using MyFarmYS.DAL.Repositories;
using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.BLL
{
    public class DogumBusiness : BaseCrudBusiness<Dogum>, IDogumRepo
    {
        public short KurudaKalmaSuresiHesapla(Dogum dogum)
        {
            throw new NotImplementedException();
        }
    }
}
