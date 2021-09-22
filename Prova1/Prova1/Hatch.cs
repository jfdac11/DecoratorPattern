using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class Hatch : Car
    {
        public Hatch()
        {
            Nome = "Corsa";

            Marca = "Chevrolet";

            Ano = "2010";

            Placa = "JAO-6666";
        }
        public override string GetCarInfo()
        {
            return "Nome: "+ Nome +
                "\nMarca: "+ Marca + 
                "\nAno: " + Ano + 
                "\nPlaca: " + Placa;
        }
    }
}
