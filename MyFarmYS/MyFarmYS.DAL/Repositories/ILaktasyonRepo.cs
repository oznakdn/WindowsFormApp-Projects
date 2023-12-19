using MyFarmYS.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.DAL.Repositories
{
    public interface ILaktasyonRepo
    {
        short LaktasyonSuresiHesapla(Laktasyon laktasyon);
        short LaktasyonSutVerimHesapla(Laktasyon laktasyon);

    }
}
