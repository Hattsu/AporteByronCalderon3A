using System;
namespace AporteByronCalderon
{
    class Profesor
    {
        public string Nombre {set; get;}
        public string Apellido {set; get;}
        public string Direccion {set; get;}
        public int Cedula {set; get;}

        public Profesor(string nombre, string apellido, string direccion, int cedula)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Cedula = cedula;
        }
    }
}