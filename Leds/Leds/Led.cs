using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leds
{
    internal class Led
    {
        private byte dados;

        public Led()
        {
            this.dados = 0; 
        }

        public byte Getdados()
        {
            return this.dados;
        }

        public void Acender(int led)
        {
            if (led >= 1 && led <= 8)
            {
                this.dados = (byte)(this.dados | (1 << (led - 1)));
            }
        }

        public void Apagar(int led)
        {
            if (led >= 1 && led <= 8)
            {
                this.dados = (byte)(this.dados & ~(1 << (led - 1)));
            }
        }
        public bool Getled(int led)
        {
            if (led >= 1 && led <= 8)
            {
                return (this.dados & (1 << (led - 1))) != 0;
            }
            return false;
        }
    }
}


