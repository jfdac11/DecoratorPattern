using System;

namespace Prova1
{
    class Program
    {
        /*
            O design pattern escolhido para solucionar o problema em questão foi o decorator, pois por meio dele é possivel adicionar
        recursos aos diferentes carros presentes no game, tornando a implementação de complementos mais fácil podendo ser feito em tempo
        de execução.
            Para isso foram criadas algumas classes que representam os componentes e decoradores, são essas:
        *Decorator - CarDecorator.
        *Concrete Decorator - Turbo, Nitro, ABS, SesorEstacionamento, DireçãoHidralica.
        *Component - Car.
        *Concrete Component - Sedan, Hatch, SUV.
            
            Dessa forma é possivel fazer com que é um determinado carro consiga obter funcionalidades advindas de novos decoradores apenas passando
        o carro como parametro do construtor do decorador concreto, tornando simples e rápida a adição dos recursos em questão.
        
        */
        static void Main(string[] args)
        {
            Car suv = new SUV();
            suv = new Nitro(suv);
            Console.WriteLine(suv.GetCarInfo());

            Car sedan = new Sedan();
            sedan = new Nitro(sedan);
            sedan = new Turbo(sedan);
            sedan = new DirecaoHidraulica(sedan);
            sedan = new ABS(sedan);
            Console.WriteLine("\n"+sedan.GetCarInfo());


            Car hatch = new Hatch();
            hatch = new SensorEstacionamento(hatch);
            hatch = new DirecaoHidraulica(hatch);
            Console.WriteLine("\n" + hatch.GetCarInfo());
        }
    }
}
