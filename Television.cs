using System;

namespace solucionEconomica
{
    class Television
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public Television Propietario { get; set; }


        //cambiar canal
        public string CambiarCanal()
        {
            return $"Cambiando canal..";
        }
        //conectarseWifi
        public string ConectarWifi()
        {
            return "Su televisión esta conectado a la red-Andres97";
        }
        public string Encender(string prNombre)
        {
            return $"Encendiendo {prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando {pNombre}";
        }
    }
}
