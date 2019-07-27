using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparación_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = { "Mike", "Lucas", "Dustin", "Eleven", "Max" }; //Variables Iniciales
            int[] Puntaje = new int[5];
            float[] Porcentaje = new float[5];
            int total = 0;




            Console.WriteLine("De acuerdo, ya cada quien tiene 3 artefactos. Con esto deberíamos poder Rescatar a Will");

            for (int i = 0; i<Nombres.Length; i++)                              //Recolección de datos
            {
                Console.WriteLine(Nombres[i] + " ¿Cuantos puntos conseguiste?");
                for(int y = 0; y < 3; y++)
                {
                    int temp = 0;
                    Console.WriteLine("Puntaje del Artefacto #" + (y+1));
                    temp = int.Parse(Console.ReadLine());
                    while(temp < 1 || temp > 100)
                    {
                        Console.WriteLine("¡Esto Es serio!, dame un numero real entre 1 y 100");
                        temp = int.Parse(Console.ReadLine());
                        if(temp > 1 && temp < 100) { break; }
                    }
                    Puntaje[i] += temp;
                    
                }              
            }
            for (int i = 0; i < Nombres.Length; i++)
            {
                total += Puntaje[i];
            }
            for (int i = 0; i < Nombres.Length; i++)
            {
                Porcentaje[i] = CalcularPorcentaje(Puntaje[i], total);
                Console.WriteLine(Nombres[i] + " Consiguió " + Puntaje[i] + " Puntos");
                Console.WriteLine(CumpleMeta(Puntaje[i]));
                Console.WriteLine("Su porcentaje fue de " + Porcentaje[i] + "\n");
                
                
            }
            Console.WriteLine("Alcanzamos a juntar " + total + " Puntos");
            if(total >= 1230)
            {
                Console.WriteLine("Lo Logramos muchachos! Liberamos A Will");
            }
            else
            {
                Console.WriteLine("Fracasamos... Estamos Condenados...");
            }
            
        }


        public static float CalcularPorcentaje(int Pon, int total)
        {
            float porcentaje = (Pon*100) / total;
            return porcentaje;
        }

        public static string CumpleMeta(int point)
        {
            if(point >= 250)
            {
                string correcto = "Cumplió con su deber";
                return correcto;
            }
            else
            {
                string incorrecto = "No hizo ni madres";
                return incorrecto;
            }
            
        }


    }
}
