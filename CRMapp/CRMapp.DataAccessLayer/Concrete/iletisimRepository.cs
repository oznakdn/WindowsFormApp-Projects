using CRMapp.DataAccessLayer.Abstract;
using CRMapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMapp.DataAccessLayer.Concrete
{
    public class iletisimRepository:BaseEFRepository<iletisim,CRMappContext>,IiletisimRepository
    {
    }
}
