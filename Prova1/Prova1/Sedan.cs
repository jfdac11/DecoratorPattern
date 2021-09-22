using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public class Sedan : Car
    {
        public Sedan()
        {
            Nome = "Classic";
            Marca = "FIAT";
            Ano = "2012";
            Placa = "PKA-0489";
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
