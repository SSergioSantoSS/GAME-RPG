using RPG_GAME.Entities;
using System;

namespace RPG_GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Monster monster = new Monster("Groor", 23, "Beast");



            Console.WriteLine(wizard.Attack());
            Console.WriteLine(monster.Attack());
        }
    }
}
