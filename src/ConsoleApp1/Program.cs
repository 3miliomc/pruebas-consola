using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        private ServicePersona _servicio;

        public Program()
        {
            _servicio = new ServicePersona();
            
        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Hola mundo y la ... {args}");
            
        }
    }
}
