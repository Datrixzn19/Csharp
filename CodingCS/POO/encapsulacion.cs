//conversor euto dolar

using System;
namespace conversormoneda
{
    class ConversorEuroDolar
    {
        public double euro = 1.3;

        public double convierte(double cantidad)
        {
            return cantidad * euro;
        }
    }
}
/*
            en el main 

            ConversorEuroDolar obj = new ConversorEuroDolar();
            Console.WriteLine(obj.convierte(100));
*/