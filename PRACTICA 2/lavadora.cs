using System;

namespace PRACTICA_2
{
    public class lavadora
    { 
        public string Tipo;
       private string _marca;
       public string Modelo;
       public DateTime FechaFabricacion;

       //PARA VALIDAR
      public string Marca
       {
           get { return _marca; }
           set
           {
               if (value == "")
               {
                   _marca = "LG";
               }
               else
               {
                   _marca = value;
               }
           }
       }


       public void Encender()
       {
           bool encender = true;
           if (encender == true)
           {
               Console.WriteLine("el electrodoméstico ({0}), esta encendido", Tipo);
           }
       }
       public void Apagar()
       {
           bool apagar = false;
           if (apagar == false)
           {
               Console.WriteLine("el electrodoméstico ({0}), esta apagado", Tipo);
           }
       }
       public void Centrifugar()
       {
           bool centrifugar = false;
           if (centrifugar == false)
           {
               Console.WriteLine("el electrodoméstico ({0}), esta centrifugando", Tipo);
           }
       }

       public void Alejandro()
       {
           string Nombre = "Alejandro";
           int Edad = 18;
           string Sector = "Sector La Paz";
           Console.WriteLine("Hola, mi nombre es {0}, tengo {1} años y vivo en {2}", Nombre, Edad, Sector);
       }

       public void Matos()
       {
           Console.WriteLine("Mi meta en esta asignatura es lograr reforzar mis conocimientos en el lenguaje \n " +
                             "de c#, asi como también descubrir nuevas cosas a lo largo del cuatrimestre.");
       }

       public void EjecutaAtributos()
       {
           Console.WriteLine("---------------------------------------");
           Console.WriteLine("Tipo de electrodoméstico: {0}\n" +
                             "Marca: {1} \n" +
                             "Modelo: {2} \n" +
                             "Fecha de fabricación: {3}",Tipo, Marca, Modelo, FechaFabricacion);
           
       }


    }
}