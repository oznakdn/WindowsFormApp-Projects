using MyFarmYS.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFarmYS.BLL
{
    public class BaseCrudBusiness<TEntity> where TEntity:class,new()
    {
        BaseCrudRepository<TEntity> baseRepo;
        public BaseCrudBusiness()
        {
            baseRepo = new BaseCrudRepository<TEntity>();

        }
        public void Ekle(TEntity entity)
        {
            baseRepo.Ekle(entity);
        }
        public void Guncelle(TEntity entity)
        {
            baseRepo.Guncelle(entity);
        }
        public void Sil(TEntity entity)
        {
            baseRepo.Sil(entity);
        }
        public List<TEntity> HepsiniGetir()
        {
            return baseRepo.HepsiniGetir();
        }

    }
}
