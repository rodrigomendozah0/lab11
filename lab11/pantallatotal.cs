using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class pantallatotal
    {
        public static float[] notas = new float[300];
        public static int contador = 0;
        
        public static int pantallaprincipal()
        {

            string texto = "================================\n" +
                "Casos con arreglos\n" +
                "================================\n" +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir (Presionar X en mantenimiento)\n" +
                "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opcion:", texto);
        }
        public static int ingresarnotas()
        {
            string texto = "================================\r\n" +
                "Registrar una nota\r\n" +
                "================================\r\n";
            Console.Write(texto);

            float notaRegistrar = Operaciones.getDecimal("Ingrese la nota : ");
            if (contador == 300)
            {
                Console.WriteLine("La lista esta llena");
            }
            notas[contador] = notaRegistrar;
            contador++;
            string texto2 = "================================\r\n" +
                "1: Registrar otra nota\r\n" +
                "2: Regresar\n";
            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingresa una opcion: ", texto);
            if (opcion == 2) return 0;

            return opcion;

        }
        public static int notamayor()
        {
            string texto = "================================\r\n" +
                "La nota mayor\r\n" +
                "================================\r\n";

            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float mayor = notas[0];
                int posicioMayor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                        posicioMayor = i;
                    }
                }

                Console.WriteLine("La nota mayor es: " + mayor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMayor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");

            }

            string texto2 = "\n1: Regresar\n";
            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
        public static int notamenor()
        {
            string texto = "================================\r\n" +
               "La nota menor\r\n" +
               "================================\r\n";

            Console.Write(texto);
            if (contador == 0)
            {
                Console.WriteLine("No existen productos todavía");
            }
            else
            {
                float menor = notas[0];
                int posicioMenor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                        posicioMenor = i;
                    }
                }

                Console.WriteLine("La nota menor es: " + menor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMenor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }

            string texto2 = "\n1: Regresar\n";
            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingresa una opción: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
        public static int buscarnota()
        {
            string texto = "================================\n" +
                "Buscar nota\n" +
                "================================\n";
            Console.Write(texto);
            
            float valorBuscar = Operaciones.getDecimal("Ingrese la nota a buscar: ");
            int posicionEncontrada = -1;
            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            if (posicionEncontrada != -1)
            {
                Console.WriteLine("La nota está en la posición " + posicionEncontrada);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.WriteLine(i + " -> [" + notas[i] + "]");
                    }
                    else
                    {
                        Console.WriteLine(i + " -> " + notas[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("La nota no se encontró en la lista.");
            }

            string texto3 = "================================\n" +
                "1: Regresar\n";

            Console.Write(texto3);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
        public static int modificarnota()
        {
            string texto = "================================\n" +
                "Modificar nota\n" +
                "================================\n";
            Console.Write(texto);

            float valorBuscar = Operaciones.getDecimal("Ingrese una nota: ");
            int posicionEncontrada = -1;

            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                    break;
                }
            }

            if (posicionEncontrada > -1)
            {
                float nuevoValor = Operaciones.getDecimal("Ingresa la nueva nota: ");
                Console.WriteLine("================================");
                Console.WriteLine("Antes:");

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                notas[posicionEncontrada] = nuevoValor;

                Console.WriteLine("\nDespués:");

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }
            else
            {
                Console.WriteLine("No se ha encontrado la nota.");
            }

            string texto2 = "================================\r\n" +
                "1: Regresar\n";

            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;


        }
        public static int vernotas()
        {
            string texto = "================================\n" +
                "Notas Registradas\n" +
                "================================\n" +
                "Notas actuales:\n";
            Console.Write(texto);
            for (int i = 0; i < contador; i++)
            {
                Console.Write(notas[i] + " - ");
            }
            Console.WriteLine();
            string texto2 = "Siguiente posición será:" + contador + "\n" +
               "================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opcion:", texto);
            if (opcion == 1) return 0;

            return opcion;
        }
    }
}
