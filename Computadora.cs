using System;

namespace solucionEconomica
{
    class Computadora

    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Almacenamiento { get; set; }
        public string Generacion { get; set; }
        public float Costo { get; set; }

        public Cliente Dueño { get; set; }

        //VideoLlamadas
        public string VideoLlamada()
        {
            return "El dispositivo se esta conectando a una videollamada..";
        }
        //bajarArchivos
        public string DescargarArchivos()
        {
            return "Sus archivos han sido descargados";
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
