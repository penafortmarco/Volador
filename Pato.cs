using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVolador
{
    class Pato : IVolador
    {
        private int unEnergia=0;

        public Pato()
        {

        }

        public void Volador()
        {
            this.unEnergia = unEnergia - 5;
            Console.WriteLine("Estoy volando como un pato...¡Cuak!");
        }
    }
}
