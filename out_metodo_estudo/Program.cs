using System;
namespace out_metodo_estudo
{

    class Program
    {
        static void Main(string[] args)
        {
            int d1, d2, quoc, rest;
            Console.WriteLine("digite o dividendo");
            d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o divisor");
            d2 = int.Parse(Console.ReadLine());
            quoc = Divisao(d1, d2, out rest);
            Console.WriteLine($"{d1}/{d2} tem quociente {quoc} e resto {rest}");
            Console.ReadLine();
        }

       static int Divisao(int dividendo, int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
