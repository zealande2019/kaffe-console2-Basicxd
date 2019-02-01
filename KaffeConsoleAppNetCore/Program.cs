using kaffe;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace KaffeConsoleAppNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Cortado cortado = new Cortado();
            Latte latte = new Latte();
            FlatWhite flatWhite = new FlatWhite(12);

            List<Imælk> Liste = new List<Imælk>();

            Liste.Add(cortado);
            Liste.Add(latte);

            foreach (var Item in Liste)
            {
                Console.WriteLine("Før Cast" + Item.MlMælk());
                if (Item is Latte)
                {
                    Latte l = Item as Latte;
                    Console.WriteLine("Latte styrke" + l.Styrke());

                }
                else if (Item is Cortado)
                {
                    Cortado c = Item as Cortado;
                }  
            }
        }
    }
}
