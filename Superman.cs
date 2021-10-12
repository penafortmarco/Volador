using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVolador
{
    class Superman : IVolador
    {
        private int experiencia;

        public Superman()
        {
        }

        public void Volador()
        {
            this.experiencia = experiencia + 3;
            Console.WriteLine("Estoy volando como Superman...");           
        }
    }
}
