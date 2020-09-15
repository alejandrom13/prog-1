using System;

namespace PRACTICA_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //EJECUTA EL METODO CON MI NOMBRE
            lavadora nombre = new lavadora();
            nombre.Alejandro();
            
            //EJECUTA EL METODO CON MI APELLIDO
            lavadora apellido = new lavadora();
            apellido.Matos();

            Console.WriteLine("");
            //EJECUTA LAS FUNCIONES DE LAVADORA
            lavadora lavadora  = new lavadora();
            lavadora.Tipo = "Lavadora";
            lavadora.Marca = "";
            lavadora.Modelo = "WD-LG-2015";
            lavadora.FechaFabricacion = new DateTime(2015, 2, 13);
            lavadora.EjecutaAtributos();
            lavadora.Encender();
            lavadora.Centrifugar();
            lavadora.Apagar();
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            
            //EJECUTA LAS FUNCIONES DE ESTUFA
            estufa estufa = new estufa();
            estufa.Tipo = "Estufa";
            estufa.Marca = "";
            estufa.Modelo = "2015-MABE";
            estufa.FechaFabricacion = new DateTime(2015, 5, 25);
            estufa.EjecutaAtributos();
            estufa.Encender();
            estufa.Apagar();
            estufa.EncenderHorno();
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            
            //EJECUTA LAS FUNCIONES DE LICUADORA
            licuadora licuadora = new licuadora();
            licuadora.Tipo = "Licuadora";
            licuadora.Marca = "";
            licuadora.Modelo = "2013-Oster";
            licuadora.FechaFabricacion = new DateTime(2013, 5, 25);
            licuadora.EjecutaAtributos();
            licuadora.Encender();
            licuadora.Apagar();
            licuadora.AumentarVel();
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            
            //EJECUTA LAS FUNCIONES DE TELEVISION
            tv television = new tv();
            television.Tipo = "Televisión";
            television.Marca = "";
            television.Modelo = "2015-LG";
            television.Resolucion = "1080p FULL HD";
            television.FechaFabricacion = new DateTime(2015, 5, 25);
            television.EjecutaAtributos();
            television.Encender();
            television.Apagar();
            television.SubirVol();
            
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            
            //EJECUTA LAS FUNCIONES DE AIRE ACONDICIONADO
            ac ac = new ac();
            ac.Tipo = "Aire Acondicionado";
            ac.Marca = "";
            ac.Modelo = "2018-ComfortStar";
            ac.btu = 18000;
            ac.FechaFabricacion = new DateTime(2018, 5, 25);
            ac.EjecutaAtributos();
            ac.Encender();
            ac.Apagar();
            ac.TurboMode();
            Console.WriteLine("---------------------------------------");

            Console.ReadKey();

        }
    }
}
