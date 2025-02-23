/*
Tienen como finalidad dar un estado inicial a los objetos 
cuando construimos objetos, este debe tener un estado inicial
es como un metodo y tendra el mismo nombre de la clase
no devolvera nada 
*/

using System;
namespace construct
{
    public class Construct
    {
        public static void cons()
        {
            //en el main: nombre de la clase ->nombre del objeto o instancia perteneciente a la clase -> nombre del contructor
            Auto auto1 = new Auto();//estado inicial, 
            Auto auto2 = new Auto(); //podemos crear mas objetos

            //imprimiendo el metodo de acceso
            System.Console.WriteLine(auto1.getFullInfo);
           
            //con los metodos llamamos al segundo contructor por los parametros 
            Auto auto3 = new Auto(3000, 5453);//instancia del ejemplo de sobrecarga de contructores
            
        }
    }

    // esta clase va a construir objetos de clase auto
    class Auto
    {
        //public para acceder a el
        public Auto()
        {
            //aqui definimos el estado incial
            llantas = 4;
            largo = 444;
            ancho = 555; 
        }

        //SOBRECARGA DE CONTRUCTORES 
        public Auto(double largoAuto, double anchoAuto)
        {
            //aqui definimos el estado incial
            llantas = 4;
            largo = largoAuto;
            ancho = anchoAuto; 
        
        }

         //metodo de acceso, se denomina getters
         //por convencion se empieza por get el nombre 
        public int getLlantas()
        {
            return llantas;
        }

        //metodo de acceso que nos de toda la informacion 
        public string  getFullInfo()
        {
            return "la informacion es: \n" + " llantas:"+  llantas + " largo:"+  largo + " ancho:"+  ancho;;
        }






        //esto tiene por defecto
        //se recomienda encapsular y acceder a ellos por un metodo de acceso
        private int llantas;
        private double largo;
        private double ancho;
        private bool climatizador;// solo para saber si lo tiene o no 
        private string tapiceria;





    }
}