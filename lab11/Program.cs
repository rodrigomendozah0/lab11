using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = pantallatotal.pantallaprincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        opcion = pantallatotal.ingresarnotas();
                        break;
                    case 2:
                        Console.Clear();
                        opcion = pantallatotal.notamayor();
                        break;
                    case 3:
                        Console.Clear();
                        opcion = pantallatotal.notamenor();
                        break;
                    case 4:
                        Console.Clear();
                        opcion = pantallatotal.buscarnota();
                        break;
                    case 5:
                        Console.Clear();
                        opcion = pantallatotal.modificarnota();
                        break;
                    case 6:
                        Console.Clear();
                        opcion = pantallatotal.vernotas();
                        break;
                    case 0:
                    default:
                        opcion = pantallatotal.pantallaprincipal();
                        break;

                }
            } while (opcion != 7);
            Console.ReadLine();
        }
    }
}
