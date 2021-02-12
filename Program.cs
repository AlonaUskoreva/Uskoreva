using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uskoreva//это название мы придумали сами и его нельзя изменить
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Hello world!");//строчка всегда должна оставаться,чтобы всегда видеть что должно писаться
            Random rnd = new Random();
            Console.WriteLine("jah-random number, ei-ise sisestan number");
            string soov = Console.ReadLine();//это как input
            int num;
            if (soov=="jah")
            {
                num = rnd.Next(1, 7);//генерирует случайное число от1 до 8
            }
            else
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Päeva number:{0}", num.ToString());
            string nimetus = "";
            switch (num)
            {
                case 1: nimetus = "esmaspäev"; break;
                case 2: nimetus = "teisipäev"; break;
                case 3: nimetus = "kolmapäev"; break;
                case 4: nimetus = "neljapäev"; break;
                case 5: nimetus = "reede"; break;
                case 6: nimetus = "laupäev"; break;
                case 7: nimetus = "pühapäev"; break;
                default:
                    nimetus = "Viga!";
                    break;
            }
            //Console.WriteLine(nimetus);
            //StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt",true);
            //filesse.WriteLine("Number oli {0},päev on {1}", num.ToString(), nimetus);
            //filesse.Close();
            //Console.WriteLine("Failis oli salveststud: Number oli" + num.ToString() + "päev on" + nimetus);
            //StreamReader filest = new StreamReader(@"..\..\andmed.txt");
            //string a = filest.ReadToEnd();// читает до конца, все что видит
            //Console.WriteLine("Failis oli seda:\n" + a);







            Console.ReadLine();
        }
    }
}
