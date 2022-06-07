using System;
namespace AporteByronCalderon
{
    class Profesor_horas:Profesor, IImprimir, ISueldo
    {
        public double Precio_horas{set; get;}
        public double Cantidad_horas{set; get;}
        public double Sueldo_total{set; get;}

        public Profesor_horas(double precio_horas, double cantidad_horas, double sueldo_total, string nombre, string apellido, string direccion, int cedula ): base(nombre, apellido, direccion, cedula)
        {
            this.Precio_horas = precio_horas;
            this.Cantidad_horas = cantidad_horas;
            this.Sueldo_total = sueldo_total;
        }

        public void Calcular()
        {
            //double sueldo_total=0;
            Sueldo_total = Precio_horas * Cantidad_horas;
            Console.WriteLine("Sueldo total: "+Sueldo_total);
        }

        public void Mostrar_datos()
        {
            Console.WriteLine("Ficha: Profesor por horas:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Dirección: "+Direccion);
            Console.WriteLine("Cedula de identidad: "+Cedula);
            Console.WriteLine("Precio de horas trabajadas: "+Precio_horas);
            Console.WriteLine("Cantidad de horas trabajadas: "+Cantidad_horas);
            //Console.WriteLine("Sueldo total: $"+Sueldo_total);
        }
    }
}