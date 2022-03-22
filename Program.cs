using System;
using JogoRPG.src.Entities;

namespace jogoRPG
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERSONAGENS DO JOGO: ");
            Knight knight = new Knight("Arus", 42, "Knight", 469, 72);
            Ninja ninja = new Ninja("Wedge", 42, "Ninja", 292, 89);
            Wirzard wirzard = new Wirzard("Jenica", 42, "White Wizard", 325, 474);
            Sorcerer sorcerer = new Sorcerer("Topapa", 42, "Black Wizard", 106, 611);
            
            Console.WriteLine(knight);
            Console.WriteLine(ninja);
            Console.WriteLine(wirzard);
            Console.WriteLine(sorcerer);
            Console.WriteLine(" ");

            Console.WriteLine(ninja.Attack(8));
            Console.WriteLine(sorcerer.Attack(21));
            Console.WriteLine("Arus é atacado pelo Jenica e Topapa");
            Console.WriteLine(wirzard.Cura(100));
            Console.WriteLine(wirzard.Attack(16));
            Console.WriteLine(knight.Attack(7));
            Console.WriteLine("Após Arus e Jenica atacarem, o Topapa morreu e o Wedge fugiu para não morrer");            
        
        }
    }
}

