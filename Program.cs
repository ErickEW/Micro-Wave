  
using System;

namespace Microondas
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Display();
        }
    }
}
//To do: 1.-Si se intenta realizar una acción incorrecta, como por ejemplo introducir comida sin abrir la puerta, debe arrojar excepciones apropiadas con un mensaje significativo.
//2.- El contenedor puede o no ser apto para microondas, y por tanto se debe arrojar una excepción según sea necesario. 
//Nota: Me salió y a la vez no, no puedo hacer que aparescan algunos de los textos que puse. Esto es todo lo q pude hacer 
