using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public abstract class CarDecorator : Car
    {
        private Car car;
        public CarDecorator(Car _car)
        {
            car = _car;
        }

        public override string GetCarInfo()
        {
            return car.GetCarInfo();
        }
    }
}
