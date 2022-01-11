using Presentacions.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacions
{
    public interface IBuilder
    {
        public void Reiniciar();
        public void SetAutor(string autor);
        public void SetGenero(string genero);
        public void SetPublicador(string publicador);
        public void SetPrecio(double precio);
        public Libro GetLibro();
    }
}
