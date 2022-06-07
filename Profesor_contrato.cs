using System;
namespace AporteByronCalderon
{
    class Profesor_contrato:Profesor, IImprimir, ISueldo
    {
        public double Sueldo_basico{set; get;}
        public double Cantidad_horas{set; get;}
        public double Precio_horas{set; get;}
        public double sueldo_total{set; get;}

        public Profesor_contrato(double sueldo_basico, double cantidad_horas, double precio_horas, double Sueldo_total, string nombre, string apellido, string direccion, int cedula ): base(nombre, apellido, direccion, cedula)
        {
            this.Sueldo_basico = sueldo_basico;
            this.Cantidad_horas = cantidad_horas;
            this.Precio_horas = precio_horas;
            this.sueldo_total = Sueldo_total;
        }

        public void Calcular()
        {
            double sueldo_total2 =0;
            sueldo_total2 = Precio_horas * Cantidad_horas;

            sueldo_total = Sueldo_basico + sueldo_total2;
            Console.WriteLine("Sueldo total: "+sueldo_total);
        }

        public void Mostrar_datos()
        {
            Console.WriteLine("Ficha: Profesor por contrato:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nombre: "+Nombre);
            Console.WriteLine("Apellido: "+Apellido);
            Console.WriteLine("Dirección: "+Direccion);
            Console.WriteLine("Cedula de identidad: "+Cedula);
            Console.WriteLine("Precio de horas trabajadas: "+Precio_horas);
            Console.WriteLine("Cantidad de horas trabajadas: "+Cantidad_horas);
            //Console.WriteLine("Sueldo total: $"+sueldo_total);
        }
    }
}