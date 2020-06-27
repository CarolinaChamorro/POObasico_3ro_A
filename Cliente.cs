using System;

namespace solucionEconomica
{
    class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        Computadora computadora;
        public Computadora Micomputadora
        {
            get
            {
                return computadora;
            }

            set
            {
                computadora = value;
                computadora.Dueño = this;
            }
        }
        Reloj reloj;
        public Reloj Mireloj
        {
            get
            {
                return reloj;
            }

            set
            {
                reloj = value;
            }
        }
        Television tv;

        public Television Mitv
        {
            get
            {
                return tv;
            }

            set
            {
                tv = value;
            }
        }
        //saludar
        public string Saludar()
        {
            return "Buen dia, ¿Me podría ayudar?";
        }
        //Pedir
        public string Pedir(string nombreProducto, string marcaProducto)
        {
            return $"Me voy a lleva el {nombreProducto} {marcaProducto}";
        }
        //pagar
        public string Pagar()
        {
            return "Le entrega el dinero";
        }
        //salir
        public string Salir()
        {
            return "Muy gracias";
        }
        public string ProductoCompu()
        {
            if (computadora != null)
                return $"me compré una computadora {computadora.Nombre} {computadora.Marca}";
            else
                return "no tengo computadora";
        }
        public string ProductoTv()
        {
            if (tv != null)
                return $"me compré un televisor {tv.Nombre} {tv.Marca}";
            else
                return "no tengo television";
        }
        public string ProductoReloj()
        {
            if (reloj != null)
                return $"me compré un reloj {reloj.Nombre} {reloj.Marca}";
            else
                return "no tengo reloj";
        }
    }
}