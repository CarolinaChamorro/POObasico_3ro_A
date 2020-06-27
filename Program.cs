using System;

namespace solucionEconomica
{
    class Program
    {
        static void Main(string[] args)
        {

            Random Id = new Random();

            //Instancias de clientes
            Computadora computadora = new Computadora
            {
                Id = Id.Next(),
                Nombre = "Notebook",
                Marca = "HP",
                Almacenamiento="1TB",
                Generacion="Intel Corei5 8th Gen",
                Costo=499
            };
            Cliente cliente1 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Camila",
                Apellido = "Cabello",
                Micomputadora = computadora
            };

            Television tele = new Television
            {
                Id = Id.Next(),
                Nombre = "Smart 2019",
                Marca = "Samsung",
                Costo=390
            };
            Cliente cliente2 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Lauren",
                Apellido = "Jauregui",
                Mitv=tele
            };
            Reloj relojito = new Reloj
            {
                Id = Id.Next(),
                Nombre = "SmartWatch 4",
                Marca = "Xiaomi",
                Costo = 60
            };
            Cliente cliente3 = new Cliente
            {
                Id = Id.Next(),
                Nombre = "Sarabi",
                Apellido = "Carvajal",
                Mireloj = relojito
            };
            Empleado trabajador1 = new Empleado
            {
                Id = 1,
                Nombre = "Normani"
            };
            Empleado trabajador2 = new Empleado
            {
                Id = 2,
                Nombre = "Dylan"
            };

            Almacen empresaTrab1 = new Almacen
            {
                Id = Id.Next(),
                Nombre = "Point Tecnical",
                Direccion = "A 2 cuadras del Colg.Mejia-Centro de Quito",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo=trabajador1
            };
            Almacen empresaTrab2 = new Almacen
            {
                Id = Id.Next(),
                Nombre = "Point Technical",
                Direccion = "AV.Maldonado-Sur de Quito",
                TipoDeEquipos = "tecnologicos",
                MiTrabajo = trabajador2
            };


            string proCompu = cliente1.ProductoCompu();
            string proTv = cliente2.ProductoTv();
            string proReloj = cliente3.ProductoReloj();
            string miTrabajo1 = empresaTrab1.PlazaTrabajo();
            string miTrabajo2 = empresaTrab2.PlazaTrabajo();
            string saludoCli1 = cliente1.Saludar();
            string saludoCli2 = cliente1.Saludar();
            string saludoCli3 = cliente1.Saludar();

            string empleadoAtenderCompu = trabajador1.Atender();
            string empleadoAtenderTv = trabajador1.Atender();
            string empleadoAtenderReloj = trabajador1.Atender();

            string empleadoRegistrarCompu = trabajador1.Registrar(computadora.Nombre);
            string empleadoRegistrarTv = trabajador1.Registrar(tele.Nombre);
            string empleadoRegistrarReloj = trabajador1.Registrar(relojito.Nombre);

            string empleadoCobrarCompu = trabajador1.Cobrar(computadora.Costo);
            string empleadoCobrarTv = trabajador1.Cobrar(tele.Costo);
            string empleadoCobrarReloj = trabajador1.Cobrar(relojito.Costo);

            string empleadoEntregarFactCompu = trabajador1.EntregarFactura();
            string empleadoEntregarFactTv = trabajador1.EntregarFactura();
            string empleadoEntregarFactReloj = trabajador1.EntregarFactura();

            string computadoraEnceder = computadora.Encender(computadora.Nombre);
            string computadoraApagar = computadora.Apagar(computadora.Nombre);
            string computadoraDescargar = computadora.DescargarArchivos();
            string computadoraVideo = computadora.VideoLlamada();

            string teleEnceder = tele.Encender(tele.Nombre);
            string teleApagar = tele.Apagar(tele.Nombre);
            string teleCanal = tele.CambiarCanal();
            string teleWifi = tele.ConectarWifi();

            string relojEnceder = relojito.Encender(relojito.Nombre);
            string relojApagar = relojito.Apagar(relojito.Nombre);
            string relojHora = relojito.DarLaHora();
            string relojPulso = relojito.TomarPulso();


            string pedirCli1 = cliente1.Pedir(computadora.Nombre, computadora.Marca);
            string pedirCli2 = cliente2.Pedir(tele.Nombre, tele.Marca);
            string pedirCli3 = cliente3.Pedir(relojito.Nombre, relojito.Marca);
            string pagarCli1 = cliente1.Pagar();
            string pagarCli2 = cliente2.Pagar();
            string pagarCli3 = cliente3.Pagar();
            string salirCli1 = cliente1.Salir();
            string salirCli2 = cliente2.Salir();
            string salirCli3 = cliente3.Salir();

            Console.WriteLine($"\tSimulación de venta de aparatos {empresaTrab1.TipoDeEquipos}");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UNA COMPUTADORA");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-Mi nombre es {trabajador2.Nombre} y hoy la antenderé yo ({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente1.Nombre}(cliente 1),busco una computadora de 1TB y Corei7");
            Console.WriteLine($"-En este momento, tenemos esta {computadora.Nombre} {computadora.Marca} {computadora.Almacenamiento} {computadora.Generacion}");
            Console.WriteLine($"-¿Se puede probar las funciones?");
            Console.WriteLine($"-Por supuesto!/ {computadoraEnceder}");
            Console.WriteLine($"-Se puede realizar videollamadas desde esta aplicación y listo/.{computadoraVideo}");
            Console.WriteLine($"Se descargan rápidamente los archivos!/.. {computadoraDescargar}");
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones/ ({miTrabajo2}).. {computadoraApagar}");
            Console.WriteLine($"-¡Me gusta mucho, me la llevo!");
            Console.WriteLine($"-Por supuesto pase a Caja");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli1}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderCompu} ");
            Console.WriteLine($"-{pedirCli1} {computadora.Almacenamiento} {computadora.Generacion}");
            Console.WriteLine($"-{empleadoRegistrarCompu}");
            Console.WriteLine($"-{empleadoCobrarCompu}");
            Console.WriteLine($"-{pagarCli1}");
            Console.WriteLine($"-{empleadoEntregarFactCompu}");
            Console.WriteLine($"-{salirCli1}");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UNA TELEVISIÓN");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-¿Que tal?, mi nombre es {trabajador2.Nombre} y te antenderé ({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente2.Nombre}(cliente 2),busco un televisor smart");
            Console.WriteLine($"-Nos acaba de llegar, esta TV {tele.Nombre} {tele.Marca}");
            Console.WriteLine($"-¿Puedo encenderla?");
            Console.WriteLine($"-Por supuesto y probarla!/ {teleEnceder}");
            Console.WriteLine($"-Se puede ver todos los canales en HD/.{teleCanal}");
            Console.WriteLine($"Se puede configurar el Wifi inalámbrico!/.. {teleWifi}");
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones/ ({miTrabajo2}).. {teleApagar}");
            Console.WriteLine($"-¡Me gusta mucho, esta TV!");
            Console.WriteLine($"-Y no es tan costosa!");
            Console.WriteLine($"-Entonces me la llevo!");
            Console.WriteLine($"-Con mucho gusto, pase a Caja por favor");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli2}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderTv} ");
            Console.WriteLine($"-{pedirCli2}");
            Console.WriteLine($"-{empleadoRegistrarTv} {tele.Marca}");
            Console.WriteLine($"-{empleadoCobrarTv}");
            Console.WriteLine($"-{pagarCli2}");
            Console.WriteLine($"-{empleadoEntregarFactTv}");
            Console.WriteLine($"-{salirCli2}");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-VENTA DE UN RElOJ");
            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"*Bienvenidos a {empresaTrab1.Nombre}");
            Console.WriteLine($"-Mucho gust, le saluda {trabajador2.Nombre} y estaré atendiendola({miTrabajo2})");
            Console.WriteLine($"-Hola mi nombre es {cliente3.Nombre}(cliente 3),busco un reloj fitness");
            Console.WriteLine($"-Por el momento tenemos este reloj {relojito.Nombre} {relojito.Marca}");
            Console.WriteLine($"-¿Qué funciones tiene?");
            Console.WriteLine($"-Tiene Alarmar,mi el pulso, y cuenta paso!/ {relojEnceder}");
            Console.WriteLine($"-Da la hora configurada en su celular/.{relojHora}");
            Console.WriteLine($"-Como le mencione mide el puso, pruebelo!/.. {relojPulso}");
            Console.WriteLine($"-Tiene muchas más aplicaciones y funciones más/ ({miTrabajo2}).. {relojApagar}");
            Console.WriteLine($"-¡Es lo que estaba buscando, me lo llevo!");
            Console.WriteLine($"-Pase a Caja, allí le pueden ayudar");
            Console.WriteLine($"---Seccion de Caja---");
            Console.WriteLine($"-{saludoCli3}");
            Console.WriteLine($"-Un gusto, le saluda {trabajador1.Nombre}({miTrabajo1}),{empleadoAtenderReloj} ");
            Console.WriteLine($"-{pedirCli3}");
            Console.WriteLine($"-{empleadoRegistrarReloj}");
            Console.WriteLine($"-{empleadoCobrarReloj}");
            Console.WriteLine($"-{pagarCli3}");
            Console.WriteLine($"-{empleadoEntregarFactReloj}");
            Console.WriteLine($"-{salirCli3}, que gentil");

            Console.WriteLine($"------------------------------------------------------");
            Console.WriteLine($"-Clientes satisfechos");
            Console.WriteLine($"------------------------------------------------------");

            Console.WriteLine($"Mi nombre es {cliente1.Nombre} y {proCompu} en {empresaTrab1.Nombre} justo {empresaTrab1.Direccion}.");
            Console.WriteLine($"Mi nombre es {cliente2.Nombre} y también {proTv} en {empresaTrab1.Nombre}, no estaba nada mal su precio.");
            Console.WriteLine($"Mi nombre es {cliente3.Nombre} y {proReloj} en {empresaTrab1.Nombre}, es una maravilla este reloj.");
      
            Console.ReadKey();





        }
    }
}
