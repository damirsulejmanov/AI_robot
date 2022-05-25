using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_robot
{
    class Program
    {
        static void Main(string[] args)
        {
            string privet = "привет"; // привет
            string howAreYou = "как дела";

            string fine = "нормально"; // как дела

            string question = "";
            string whatIsYourName = "как тебя зовут";
            string poka = "пока";
            string ne ponimayu = "я не понимаю";
            while (question != poka)
            {
                question = Console.ReadLine();
                if (question == privet)
                {
                    Console.WriteLine(privet);
                }
                else if (question == howAreYou)
                {
                    Console.WriteLine(howAreYou);
                }
                else if (question == fine)
                {
                    Console.WriteLine(fine);
                }
                else if (question == whatIsYourName)
                {
                    Console.WriteLine("Настя");
                }
                else if (question == poka)
                {
                    Console.WriteLine(poka);
                }
            }

            

        }
    }
}
