using System;
using System.Collections.Generic;

namespace Microondas
{
    class Menu
    {
        private const int MAIN_MENU_EXIT_OPTION = 9;
        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 });
        public List<int> seleccionarComida = new List<int>(new int[] { 1, 2, 3 });
        public List<int> seleccionarContenedor = new List<int>(new int[] { 1, 2, 3 });
        public Contenedor contenedorSeleccionado = null;
        public Comida comidaSeleccionada = null;

        Microondas microondas = new Microondas();


        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("Selecciona una opción");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) Abrir puerta");
            System.Console.WriteLine("2) Cerrar puerta");
            System.Console.WriteLine("3) Elegir comida");
            System.Console.WriteLine("4) Elegir contenedor");
            System.Console.WriteLine("5) Introducir comida al microondas");
            System.Console.WriteLine("6) Calentar comida");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        {
            System.Console.WriteLine("Tu comida esta lista");
        }

        public int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("Opción invalida o Inexistente");
                }
            }

            return userInputAsInt;
        }

        private void OpcionesComida()
        {
            System.Console.WriteLine("Seleciona la comida que quieres calentar");
            System.Console.WriteLine("1) Chilaquiles");
            System.Console.WriteLine("2) Frijoles");
            System.Console.WriteLine("3) Maruchan");

        }

        public void ElegirComida()
        {
            int selectedOption = 0;


            OpcionesComida();

            selectedOption = RequestOption(seleccionarComida);

            switch (selectedOption)
            {
                case 1:
                    comidaSeleccionada = new Comida("Chilaquiles");
                    break;
                case 2:
                    comidaSeleccionada = new Comida("Frijoles");
                    break;
                case 3:
                    comidaSeleccionada = new Comida("Maruchan");
                    break;

            }
            System.Console.WriteLine($"Comida seleccionada: {comidaSeleccionada}");
        }

        private void OpcionesContenedor()
        {
            System.Console.WriteLine("Seleciona el contenedor para calentar la comida");
            System.Console.WriteLine("1) Contenedor de plástico");
            System.Console.WriteLine("2) Lata de aluminio");
            System.Console.WriteLine("3) Contenedor de unicel");

        }

        public void Elegircontenedor()
        {
            int selectedOption = 0;

            OpcionesContenedor();

            selectedOption = RequestOption(seleccionarContenedor);

            switch (selectedOption)
            {
                case 1:
                    contenedorSeleccionado = new Contenedor("Contenedor de plástico", true);
                    break;
                case 2:
                    contenedorSeleccionado = new Contenedor("Lata de aluminio", false);
                    break;
                case 3:
                    contenedorSeleccionado = new Contenedor("Contenedor de unicel", false);
                    break;

            }
        }





        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        microondas.AbrirPuerta();
                        break;

                    case 2:
                        microondas.CerrarPuerta();
                        break;

                    case 3:
                        ElegirComida();
                        break;

                    case 4:
                        Elegircontenedor();
                        break;

                    case 5:
                        microondas.IntroducirAlimento(contenedorSeleccionado, comidaSeleccionada);
                        break;

                    case 6:
                        microondas.CalentarComida();
                        break;

                }
            }

            DisplayByeMessage();

        }
    }
}
