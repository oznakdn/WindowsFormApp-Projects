using CRMapp.BusinessLogicLayer.Abstract;
using CRMapp.DataAccessLayer.Abstract;
using CRMapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.BusinessLogicLayer.Concrete
{
    public class KullaniciService : IKullaniciService
    {
        IKullaniciRepository repository;
        public KullaniciService(IKullaniciRepository _repository)
        {
            repository = _repository;
        }
        public void Add(Kullanici entity)
        {
            repository.Add(entity);
        }

        public void Update(Kullanici entity)
        {
            repository.Update(entity);
        }
    }
}
