using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eigene_Aufgabe
{
    class Program
    {
        static void Main(string[] args)

        {
            int auswahl;
            String Nochmal;
            do
            {
                Console.WriteLine("Auswhalmenü:");
                Console.WriteLine("1: Summe der ganzen Zahlen von a bis b");
                Console.WriteLine("2 : Verflixte 7.");
                Console.WriteLine("3 : °C in °F umrechnen");
                auswahl = Convert.ToInt32(Console.ReadLine());
                if (auswahl == 1)


                {
                    Console.WriteLine("Summe der ganzen Zahlen von a bis b berechnen ");
                    Console.WriteLine("a:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("b:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(" Die Summe von " + a + " und " + b + " beträgt " + summe(a, b));





                }
                else if (auswahl == 2)
                {
                    Console.WriteLine(" Verflixte 7");
                    Console.WriteLine(" Zahl eingeben :");
                    int Zahl = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("--" + Zahl + "--");
                }
                else if (auswahl == 3)
                {
                    Double t, c, f;
                    Console.WriteLine(" Temperatur eingeben: ");
                    t = Convert.ToInt32(Console.ReadLine());
                    f = 32 + t * 1.8;
                    Console.WriteLine("{0}°C entsprechend {1}°F", t, f);
                    c = Math.Round((t - 32) / 1.8,1);
                    Console.WriteLine("{0}°F entsprechend {1}°C", t, c);


                }
                Console.ReadKey();


                 

                    Console.WriteLine("Neue Auswhal? (j/n)");
                Nochmal = Console.ReadLine();
            }
            while (Nochmal == "j" || Nochmal == "J");





        }
        static int summe (int a, int b)
        {
            int zahl1, zahl2, zahl3,s=0;
            zahl1 = a;
            zahl2 = b;

            zahl3 = zahl1;
            while (zahl3 <= zahl2)
            {
                s += zahl1 + 1;
                zahl3++;
            }
                return s;
        }
        


           
            



        
       
        
        }
    }

