using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class SUV :Car
    {
        public SUV()
        {
            Nome = "Dodge";
            Marca = "Renault";
            Ano = "2019";
            Placa = "DVI-2469";
        }

        public override string GetCarInfo()
        {
            return "Nome: " + Nome +
                "\nMarca: " + Marca +
                "\nAno: " + Ano +
                "\nPlaca: " + Placa;
        }

    }
}
