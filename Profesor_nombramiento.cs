using System;
namespace AporteByronCalderon
{
    class Profesor_nombramiento:Profesor, IImprimir, ISueldo
    {
        public double Sueldo_fijo{set; get;}
        public Profesor_nombramiento(double sueldo_fijo, string nombre, string apellido, string direccion, int cedula ): base(nombre, apellido, direccion, cedula)
        {
            this.Sueldo_fijo = sueldo_fijo;
        }

        public void Calcular()
        {
            do
            {
                Console.WriteLine("Ingrese sueldo mayor a 1000: ");
                Sueldo_fijo = Convert.ToDouble(Console.ReadLine());

            }while(Sueldo_fijo<1000);
            Console.WriteLine("Sueldo total: "+Sueldo_fijo);
        }

        public void Mostrar_datos()
        {
            Console.WriteLine("Ficha: Profesor por contrato:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Dirección: "+Direccion);
            Console.WriteLine("Cedula de identidad: "+Cedula);
            //Console.WriteLine("Sueldo total: $"+Sueldo_fijo);
        }
    }
}