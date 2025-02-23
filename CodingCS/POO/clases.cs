//


using System;

namespace introClases
{

    class Circulo
    {

        //se usa cont cuando exista un valor que no debe cambiar 
        const double pi = 3.1416; //una propiedad de la clase circulo. denominado campo de clase
        public double CalcularArea(int radio)//metodo de clase
        {
            return pi * radio * radio;
        }
    }
            //en el main va:
/*
 //nombre de clase y metodo
            Circulo miCirculo; //creacion de un objeto
            miCirculo = new Circulo(); //inicializacion - instanciacion de la clase - ejemplar de una clase
            Console.WriteLine(miCirculo.CalcularArea(4));



            Circulo miCirculo2 = new Circulo(); //inicializamos pero ahroa en una sola linea de codigo
            Console.WriteLine(miCirculo.CalcularArea(6));

*/


}

