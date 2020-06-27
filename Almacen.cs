using System;

namespace solucionEconomica
{
    class Almacen
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string TipoDeEquipos { get; set; }

        Empleado trabajador;
        public Empleado MiTrabajo
        {
            get
            {
                return trabajador;
            }

            set
            {
                trabajador = value;
            }
        }

        public string PlazaTrabajo()
        {
            if (trabajador.Id == 1)
                return $"cajera";
            else
                return $"vendedor";
        }

    }
}
