using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class Turbo : CarDecorator
    {
        public Turbo(Car car) : base(car)
        {

        }
        public override string GetCarInfo()
        {
            return base.GetCarInfo() + "\nAdd On: Turbocompressor";
        }
    }
}
