using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BusinessLogic.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        /* Form içinde Constructor'a parametre giremediğimiz için bu class'ı ve aşağıdaki metodu oluşturuyoruz.
         * Eğer Asp.Net de çalışsaydık BusinessModule Class'ı yeterli olacaktı.
         */
        public static T GetInstance<T>()
        {
            var kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
