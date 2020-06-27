using System;

namespace solucionEconomica
{
    class Reloj
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Costo { get; set; }
        public Reloj Clientes { get; set; }

        //dar la hora
        public string DarLaHora()
        {
            return $"17:20/Clima despejado";
        }
        //tomar pulso
        public string TomarPulso()
        {
            return "Su pulso cardiaco es de: 82 BPM";
        }
        public string Encender(string prNombre)
        {
            return $"Encendiendo{prNombre}";
        }
        public string Apagar(string pNombre)
        {
            return $"Apagando{pNombre}";
        }

        public static implicit operator Reloj(Cliente v)
        {
            throw new NotImplementedException();
        }
    }
}
