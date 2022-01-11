using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacions.Builder
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string Publicador { get; set; }
        public double Precio { get; set; }

        public override string ToString()
        {
            return IdLibro+" "+Autor+" "+Genero+" "+Publicador+" "+Precio;
        }

    }
}
