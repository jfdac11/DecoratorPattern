using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class Nitro : CarDecorator
    {
        public Nitro(Car car):base(car)
        {
            
        }
        public override string GetCarInfo()
        {
            return base.GetCarInfo() + "\nAdd On: Nitro";
        }
    }
}
