using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wema.BIT.Abstract;

namespace Wema.BIT.IRepository.Repository
{
    public class ImplementatAnimal : AAnimal
    {
        public override void animalSouund()
        {
            Console.WriteLine("this animal sleep way up");
        }
    }
}
