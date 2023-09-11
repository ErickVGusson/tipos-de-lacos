using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipos_lacos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1 - Do While \n2 - For \n3 - Switch Case \n4 - Array \nEscolha uma opção: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            int menu = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.Clear();

            //Exemplo 1: utilizando o Do e While
            if (menu == 1)
            {

                //do
                //{
                // techo do codigo
                //} while (true)

                int contador = 1;
                while (contador <= 3)
                {

                    Console.Write("\nWhile: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(contador);
                    Console.ResetColor();
                    contador++;

                } //Ele executa pelo menos uma vez o código
                do
                {

                    Console.Write("\nDo while: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(contador);
                    Console.ResetColor();
                    contador++;

                } while (contador <= 9);
                //do { codigo } while ( condição )

            }

            //Exemplo 2: utilizando o For
            else if (menu == 2)
            {

                // for ( definição do contador; condição; incremento) { código }

                for (int cont = 0; cont < 3; cont++)
                {

                    Console.Write("\nFor: ");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(cont);
                    Console.ResetColor();

                }

            }

            //Exemplo 3: utilizando o Switch
            else if (menu == 3)
            {

                Console.Write("Digite um valor de 0 a 4: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int condicao = int.Parse(Console.ReadLine());
                Console.ResetColor();

                switch (condicao)
                {

                    case 0:
                        Console.WriteLine("Estou na condição 0");
                        break;

                    case 1:
                        Console.WriteLine("Estou na condição 1");
                        break;

                    case 2:
                        Console.WriteLine("Estou na condição 2");
                        break;

                    case 3:
                        Console.WriteLine("Estou na condição 3");
                        break;

                    case 4:
                        Console.WriteLine("Estou na condição 4");
                        break;

                    default:
                        Console.WriteLine("Você escolheu uma opção invalida");
                        break;

                }

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n\n\n\nPressione qualquer tecla para encerrar...");
            Console.ReadKey();
        }
    }
}
