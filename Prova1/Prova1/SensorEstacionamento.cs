using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class SensorEstacionamento : CarDecorator
    {
        public SensorEstacionamento(Car car) : base(car)
        {

        }
        public override string GetCarInfo()
        {
            return base.GetCarInfo() + "\nAdd On: Sensor Estacionamento";
        }
    }
}
