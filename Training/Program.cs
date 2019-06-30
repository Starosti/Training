using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Program
    {    
        static void RGBHEX()
        {
            Console.WriteLine("enter a rgb value separated by commas([255,0,0]ex.):");
            Console.WriteLine("value is:#" + RGB2HEX.TurnToHex(Console.ReadLine().Split(',').Select(n => Convert.ToInt32(n)).ToArray()));
        }
        static void Addition_()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Addition.DoAddition(a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(b);
        }
        static void SelectProgram()
        {
            Console.WriteLine(@"select the program
0=addition
1=rgb2hex");
        }
        static void Main(string[] args)
        {
            while (true)
            {
                SelectProgram();
                string selection = Console.ReadLine();
                while (selection == "0") Addition_();
                while (selection == "1") RGBHEX();
                if (!int.TryParse(selection, out int dabOnTheHaters)) Console.WriteLine("please do a proper input");
            }            
        }
    }
}
