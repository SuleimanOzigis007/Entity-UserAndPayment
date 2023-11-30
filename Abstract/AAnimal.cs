using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wema.BIT.Abstract
{
    public abstract class AAnimal
    {
        public abstract void animalSouund();
        public void sleep()
        {
            Console.WriteLine("zzz");
        }
    }
}
