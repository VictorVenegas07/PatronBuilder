using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacions.Builder
{
    public class LibroBuilder:IBuilder
    {
        public Libro Libro { get; set; }
        public void Reiniciar()
        {
            Libro = new Libro();
        }
        public void SetAutor(string autor)
        {
            this.Libro.Autor = autor;
        }
        public void SetGenero(string genero)
        {
            this.Libro.Genero = genero;
        }
        public void SetPublicador(string publicador)
        {
            this.Libro.Publicador = publicador;
        }
        public void SetPrecio(double precio)
        {
            this.Libro.Precio = precio;
        }
        public Libro GetLibro()
        {
            return this.Libro;
        }
        public override string ToString()
        {
            return Libro.ToString();
        }
    }
}
