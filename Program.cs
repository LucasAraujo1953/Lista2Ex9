using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p;
            double a;
            double r;
            string S;

            Console.WriteLine("Digite seu sexo: ");
            S = Console.ReadLine();
            Console.Write("Digite seu peso: ");
            p=double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            a=double.Parse(Console.ReadLine());

            r = p / (Math.Pow(a, 2));

            {
                if ((S == "Feminino") || (S == "feminino") || (S == "FEMININO"))
                    if (r < 19)
                        Console.WriteLine("Abaixo do peso");
                    else if (r >= 24)
                        Console.WriteLine("Acima do peso");
                    else Console.WriteLine("peso ideal");
            }

            {
                if ((S == "Masculino") || (S == "masculino") || (S == "MASCULINO"))
                    if (r < 20)
                        Console.WriteLine("Abaixo do peso");
                    else if (r >= 25)
                        Console.WriteLine("Acima do peso");
                    else Console.WriteLine("peso ideal");
            }




        }
    }
}
