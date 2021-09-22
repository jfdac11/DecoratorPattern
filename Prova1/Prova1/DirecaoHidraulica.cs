using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class DirecaoHidraulica : CarDecorator
    {
        public DirecaoHidraulica(Car car) : base(car)
        {

        }
        public override string GetCarInfo()
        {
            return base.GetCarInfo() + "\nAdd On: Direção Hidraulica";
        }
    }
}
