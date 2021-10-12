using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainVolador
{
    class Boing747 : IVolador
    {
        private int hsVuelo=0;

        public Boing747()
        {
        }

        public void Volador()
        {
            this.hsVuelo = hsVuelo + 13;
            Console.WriteLine("Estoy volando como un avión...");
        }
    }
}
