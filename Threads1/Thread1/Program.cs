using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Para usar Hilos
using System.Threading;

namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {


            Thread hilo = new Thread(pintarCaracter);
            hilo.Start();
            // hilo.Join();
            Thread.Sleep(2000);
            pintarY();
            Thread.Sleep(2000);

            Thread hilo2 = new Thread(() => pintarPalabras(".NET","C#"));
            hilo2.Start();


            // para que la consola espere y no se cierre
            Console.Read();

        }


        public static void pintarCaracter()
        {

            for (int i = 0; i < 1000 ; i++)
            {
                Console.WriteLine("X"+i);
            }

        }

        public static void pintarY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Y"+i);
            }
        }

        public static void pintarPalabras(String p1, String p2)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(p1 + " " + p2);
            }
        }

    }
}
