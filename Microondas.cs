using System;

namespace Microondas
{
    class Microondas
    {
        private bool puertaEstaAbierta = false;
        Contenedor contenedorAdentro = null;




        public void AbrirPuerta()
        {
            if (puertaEstaAbierta == false)
            {
                puertaEstaAbierta = true;
                System.Console.WriteLine("Abriste la puerta");
            }
            else
            {
                System.Console.WriteLine("Puerta abierta previamente");
            }
        }

        public void IntroducirAlimento(Contenedor contenedor, Comida comida)
        {
            
            System.Console.WriteLine($"Calentar {contenedor} con {comida}");
            contenedorAdentro = contenedor;
        }

        public void CerrarPuerta()
        {
            if (puertaEstaAbierta == true)
            {
                puertaEstaAbierta = false;
                System.Console.WriteLine("Cerraste la puerta");
            }
            else
            {
                System.Console.WriteLine("Puerta cerrada previamente");
            }
        }
        public void CalentarComida()
        {

        }


    }
}