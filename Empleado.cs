using System;

namespace solucionEconomica
{
    class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
       public Empleado Servidor { get; set; }
        public string Atender()
        {
            return "¿En qué le puedo ayudar?";
        }
        public string Registrar(string NombreProducto)
        {
            return $"Buscando en el sistema {NombreProducto}";
        }
        public string Cobrar(float CostoProducto)
        {
            return $"El costo del artículo es de: {CostoProducto}";
        }
        public string EntregarFactura()
        {
            return "Muchas gracias pos su cobra, vuelva pronto!";
        }
    }
}
