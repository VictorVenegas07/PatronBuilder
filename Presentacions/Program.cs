using Presentacions.Builder;
using System;

namespace Presentacions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CrearNuevolibro();
        }

        public static void CrearNuevolibro()
        {
            Creador creador = new Creador();
            LibroBuilder builder = new LibroBuilder();
            creador.CrearLibro(builder);
            var libro = builder.GetLibro();
            builder.Reiniciar();
            builder.SetAutor("Victor Venegas");
            builder.SetGenero("Drama");
            builder.SetPublicador("France");
            builder.SetPrecio(2000);
            Console.WriteLine(builder.GetLibro().ToString());
            
        }
    }
}
