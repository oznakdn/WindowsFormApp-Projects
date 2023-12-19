using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMapp.Model;

namespace CRMapp.BusinessLogicLayer.Abstract
{
    public interface IKullaniciService
    {
        void Add(Kullanici entity);
        void Update(Kullanici entity);
    }
}
