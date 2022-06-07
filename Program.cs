using System;
namespace AporteByronCalderon
{
    class Program{
        public static void Main(String[] args)
        {
            Profesor_horas profesor_Horas = new Profesor_horas(10, 20, 1000, "Roberto", "Mero", "Calle 12, Av. 30", 13250445);
            profesor_Horas.Mostrar_datos();
            profesor_Horas.Calcular();

            Profesor_contrato profesor_Contrato = new Profesor_contrato(400, 20, 5 , 0, "Iris", "Tejena", "Calle 20, Av. 10", 1453655);
            profesor_Contrato.Mostrar_datos();
            profesor_Contrato.Calcular();
            
            Profesor_nombramiento profesor_Nombramiento= new Profesor_nombramiento (0, "Diego", "Neira", "Calle 13, Av. 23", 135247687);
            profesor_Nombramiento.Mostrar_datos();
            profesor_Nombramiento.Calcular();

        }
    }
}