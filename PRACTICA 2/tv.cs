using System;
namespace PRACTICA_2
{
    public class tv
    {
        public string Tipo;
        public string _marca;
        public string Modelo;
        public string Resolucion;
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
        //SUBIR VOLUMEN
        public void SubirVol()
        {
            string subirVol = "subiendo volumen";
            Console.WriteLine("el electrodoméstico ({0}), esta {1}", Tipo, subirVol);
            
        }
        public void EjecutaAtributos()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Tipo de electrodoméstico: {0}\n" +
                              "Marca: {1} \n" +
                              "Modelo: {2} \n" +
                              "Resolución: {3} \n" +
                              "Fecha de fabricación: {4}",Tipo, Marca, Modelo, Resolucion, FechaFabricacion);
           
        }

    }
}