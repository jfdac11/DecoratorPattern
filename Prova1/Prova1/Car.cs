namespace Prova1
{
    public abstract class Car
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Placa { get; set;}
        public virtual string GetCarInfo()
        {
            return "Nome: " + Nome +
                "\nMarca: " + Marca +
                "\nAno: " + Ano +
                "\nPlaca: " + Placa; ;
        }
    }
}