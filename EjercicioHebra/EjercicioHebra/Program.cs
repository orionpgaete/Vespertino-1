using EjercicioHebra.Hebras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioHebra
{
    class Program
    {
        static void ejecutar()
        {
            int i = Convert.ToInt32(Thread.CurrentThread.Name);
            Thread.Sleep(i* 1000);
            Console.WriteLine("Hola desde {0}", i);
        }

        static void ejecutarconparametro(object o)
        {
            int i = (int)o;
            Thread.Sleep(i * 1000);
            Console.WriteLine("Hola desde {0}", i);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iniciando Hebras");
            for (int i=1; i<7; i++)
            {
                //Thread t = new Thread(new ThreadStart(ejecutar));
                // Thread t = new Thread(new ParameterizedThreadStart(ejecutarconparametro));
                // t.Name = i.ToString();
                // t.Start(i);
                HebraEjercicio he = new HebraEjercicio(i);
                Thread t = new Thread(new ThreadStart(he.ejecutar));
                t.Start();
            }
            Console.WriteLine("Hebras iniciadas");
            Console.ReadKey();
        }
    }
}
