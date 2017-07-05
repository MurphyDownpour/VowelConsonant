using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaitSamit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Simvol daxil edin: ");
            char a = Convert.ToChar(Console.ReadLine());
                switch (a)
                {
                    case 'a':
                        Console.WriteLine("Sait.");
                        break;
                    case 'A':
                        Console.WriteLine("Sait.");
                        break;
                    case 'e':
                        Console.WriteLine("Sait.");
                        break;
                    case 'E':
                        Console.WriteLine("Sait.");
                        break;
                    case 'i':
                        Console.WriteLine("Sait.");
                        break;
                    case 'I':
                        Console.WriteLine("Sait.");
                        break;
                    case 'o':
                        Console.WriteLine("Sait.");
                        break;
                    case 'O':
                        Console.WriteLine("Sait.");
                        break;
                    case 'u':
                        Console.WriteLine("Sait.");
                        break;
                    case 'U':
                        Console.WriteLine("Sait.");
                        break;
                    default:
                        Console.WriteLine("Samit");
                        break;
                }
            }
            
        }
    }

