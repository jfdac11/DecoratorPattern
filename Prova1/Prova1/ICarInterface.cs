using System;
using System.Collections.Generic;
using System.Text;

namespace Prova1
{
    public interface ICarInterface
    {
        public string Nome { get; }
        public string Marca { get; }
        public string Ano { get; }
        public string Placa { get; }
        public string GetCarInfo();
    }
}
