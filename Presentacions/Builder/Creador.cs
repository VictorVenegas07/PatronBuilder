using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacions
{
    public class Creador
    {
        public IBuilder Builder { get; set; }
        public void CrearLibro(IBuilder builder_)
        {
            Builder = builder_;
        }
    }
}
