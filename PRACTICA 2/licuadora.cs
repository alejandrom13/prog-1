using System;
namespace PRACTICA_2
{
    public class licuadora
    {
        public string Tipo;
        public string _marca;
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
                    _marca = "Oster";
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
        public void AumentarVel()
        {
            string aumentarVel = "aumentando velocidad";
            Console.WriteLine("el electrodoméstico ({0}), esta {1}", Tipo, aumentarVel);
            
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