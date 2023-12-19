using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.DAL.Repositories
{
    public interface IDogumRepo
    {
        short KurudaKalmaSuresiHesapla(Dogum dogum);
    }
}
