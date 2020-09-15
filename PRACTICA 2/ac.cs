using System;
namespace PRACTICA_2
{
    public class ac
    {
        public string Tipo;
        public string _marca;
        public string Modelo;
        public int btu;
        public DateTime FechaFabricacion;
        
        //PARA VALIDAR
        public string Marca
        {
            get { return _marca; }
            set
            {
                if (value == "")
                {
                    _marca = "ComfortStar";
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
        
        public void TurboMode()
        {
            string turboMode = "activando TurboMode";
            Console.WriteLine("el electrodoméstico ({0}), esta {1}", Tipo, turboMode);
            
        }
        public void EjecutaAtributos()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Tipo de electrodoméstico: {0}\n" +
                              "Marca: {1} \n" +
                              "Modelo: {2} \n" +
                              "Cantidad de BTU: {3} \n" +
                              "Fecha de fabricación: {4}",Tipo, Marca, Modelo, btu, FechaFabricacion);
           
        }

    }
}