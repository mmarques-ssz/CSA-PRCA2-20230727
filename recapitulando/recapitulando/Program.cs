using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recapitulando
{
    internal class Program
    {
        static void funcao1(string s, int qtde)
        {
            string x;
            x = "Estou na funcao1() com argumentos";
            Console.WriteLine(x);
            for (int i = 1; i <= qtde; i++)
            {
                Console.WriteLine(s);
            }
        }

        static void funcao1()
        {
            string x;
            x = "Estou na funcao1() sem argumentos";
            Console.WriteLine(x);
        }

        static double dobrar(double i)
        {
            return i * 2;
        }
        static int dobrar(int i)
        {
            return i * 2;
        }

        static string geraString(string caracter, int qtde)
        {
            string strRetorno = "";
            for(int i=1; i <= qtde; i++)
            {
                strRetorno += caracter;
            }
            return strRetorno;
        }

        static void janelinha(int col, int lin)
        {
            string horiz = geraString("-", col);
            string vert = "|" + geraString(" ", col - 2) + "|";
            Console.WriteLine(horiz);
            for(int i=1; i<=(lin-2); ++i)
            {
                Console.WriteLine(vert);
            }
            Console.WriteLine(horiz);
        }

        static void janelinha(int col, int lin, ConsoleColor cor)
        {
            string horiz = geraString("-", col);
            string vert = "|" + geraString(" ", col - 2) + "|";
            Console.BackgroundColor = cor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(horiz);
            for (int i = 1; i <= (lin - 2); ++i)
            {
                Console.WriteLine(vert);
            }
            Console.WriteLine(horiz);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args)
        {
            string a;
            int z;
            janelinha(30, 10, ConsoleColor.Blue);
            janelinha(40, 15, ConsoleColor.Red);
            a = "teste";
            Console.WriteLine("Estou na função main()");
            funcao1(a, 5);
            Console.WriteLine("Voltei para a função main()");
            funcao1("Timão ê ô", 10);
            funcao1();

            //Console.Write("Digite um valor inteiro: ");
            //z = int.Parse(Console.ReadLine());
            z = 6;
            Console.WriteLine(dobrar(z));
            Console.WriteLine(dobrar(5.5));
            Console.WriteLine(geraString("#", 30));
            funcao1(geraString("*", 40), dobrar(5));

            Console.WriteLine("{0}{1}", geraString("A", 10), geraString("B", 15));
            janelinha(70, 15);


        }

        
    }
}
