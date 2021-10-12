using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVolador
{
    class Program
    {
        static void Main(string[] args)
        {
            TorreDeControl torre = new TorreDeControl();
            Pato x = new Pato();
            Boing747 z = new Boing747();
            Superman p = new Superman();

            torre.agregarVolador(x);
            torre.agregarVolador(z);
            torre.agregarVolador(p);

            torre.vuelenTodos();
            Console.ReadKey();

        }
    }
}
