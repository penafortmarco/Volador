using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVolador
{
    class TorreDeControl
    {
        List<IVolador> Voladores = new List<IVolador>();
        public void vuelenTodos()
        {
            foreach(IVolador i in Voladores)
            {
                i.Volador();
            }
        }
        public void agregarVolador(IVolador x)
        {
            Voladores.Add(x);
        }
    }
}
