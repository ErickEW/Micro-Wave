using System;

namespace Microondas
{
    class Comida
    {
        public string comida { get; set;}
        public Comida(string comida)
        {
            this.comida = comida;
        }

        public string Tomarcomida()
        {
            return comida;
        }
    }
}